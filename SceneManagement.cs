using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public int currentScene;
    public int nextScene;
    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        nextScene = currentScene + 1;
    }
    public void NextLvl()
    {
        SceneManager.LoadScene(nextScene);
    }
    public void Restart()
    {
        SceneManager.LoadScene(currentScene);
    }
}
