using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneScript : MonoBehaviour
{
    public Slider slider;
    public SceneManagement sceneManagement;
    public SaveSystem saveSystem;
    private void Start()
    {
        if (saveSystem.savedScene == 0)
            saveSystem.savedScene++;
        LoadLvl();
    }
    public void LoadLvl()
    {
        StartCoroutine("LoadASync");
    }
    IEnumerator LoadASync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(saveSystem.savedScene);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
