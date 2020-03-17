using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class LoseSliderLogic : MonoBehaviour
{
    public Slider slider;
    public Text retryCounterText;
    public int retryCounter;
    public UnityEvent action;
    void Start()
    {
        retryCounterText.text = "" + retryCounter;
        slider.value = 1;
    }
    public void StartSlider()
    {
        StartCoroutine("DecreaseSliderValue");
        StartCoroutine("DecreaseCounterValue");
    }

    IEnumerator DecreaseSliderValue()
    {
        while (slider.value > 0)
        {
            yield return new WaitForSecondsRealtime(.1f);
            slider.value -= .02f;

        }
        if (slider.value == 0)
        {
            action.Invoke();
        }

    }
    IEnumerator DecreaseCounterValue()
    {
        while (retryCounter > 0)
        {
            yield return new WaitForSecondsRealtime(1f);
            retryCounter--;
            retryCounterText.text = "" + retryCounter;

        }


    }

}
