using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSlider : MonoBehaviour
{
    public GameObject player;
    public Slider slider;
    SceneManagement sceneManagementScript;
    public PlayerMovement playerMovementScript;
    public Text currentLvlText,
        nextLvlText;
    private void Start()
    {
        sceneManagementScript = GetComponent<SceneManagement>();
        currentLvlText.text ="" + sceneManagementScript.currentScene;
        nextLvlText.text = "" + sceneManagementScript.nextScene;
        StartCoroutine("SliderIncreaser");
    }
    IEnumerator SliderIncreaser()
    {
        while (slider.value != slider.maxValue)
        {
            slider.value = player.transform.position.z;
            yield return new WaitForSecondsRealtime(.1f);
        }


    }
}
