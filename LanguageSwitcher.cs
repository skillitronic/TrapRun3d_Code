using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LanguageSwitcher : MonoBehaviour

{
    SaveSystem saveSystem;
    public Text[] textToChange;
    private void Awake()
    {

        saveSystem = GetComponent<SaveSystem>();
        if (saveSystem.languageSwitch == 1)
        {
            SwitchRus();
        }
        else if (saveSystem.languageSwitch == 0)
        {
            SwitchEng();
        }
    }
    public void SwitchRus()
    {
        textToChange[0].text = "ПОПРОБОВАТЬ СНОВА?";
        textToChange[1].text = "ПРОПУСТИТЬ";
        textToChange[2].text = "НАЖМИТЕ ЧТОБЫ ПЕРЕЗАПУСТИТЬ";
        textToChange[3].text = "Зажмите чтобы остановить движение";
        textToChange[4].text = "Нажмите чтобы начать";
        textToChange[5].text = "Язык";
        textToChange[6].text = "Политика конфендициальности";
        textToChange[7].text = "УРОВЕНЬ ПРОЙДЕН";
        textToChange[8].text = "Нажмите чтобы продолжить";
        textToChange[9].text = "ПОЛУЧИТЬ БЕСПЛАТНЫЕ \n ОСКОЛКИ";
        saveSystem.languageSwitch = 1;
        saveSystem.SaveLanguageData();
    }
    public void SwitchEng()
    {
        textToChange[0].text = "TRY AGAIN?";
        textToChange[1].text = "SKIP \n LEVEL";
        textToChange[2].text = "TAP TO RESTART";
        textToChange[3].text = "Hold to stop moving";
        textToChange[4].text = "Tap to start";
        textToChange[5].text = "Language";
        textToChange[6].text = "Privacy Policy";
        textToChange[7].text = "LEVEL PASSED";
        textToChange[8].text = "Tap to continue";
        textToChange[9].text = "GET FREE \n SHARDS";
        saveSystem.languageSwitch = 0;
        saveSystem.SaveLanguageData();
    }
}
