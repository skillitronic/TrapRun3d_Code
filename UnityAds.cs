using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour
{
    private string gameId = "3448798";
    private string rewardVid = "rewardedVideo";
    private string normalVid = "video";
    private string bannerid = "gameBanner";
    public GameObject secondChanceButton,
        getFreeCoinsButton;
    public CoinLogic coinLogic;
    SaveSystem saveSystem;
    
    private void Awake()
    {
        saveSystem = GetComponent<SaveSystem>();
#if UNITY_ADS
        secondChanceButton.SetActive(true);
        getFreeCoinsButton.SetActive(true);
#endif
        Advertisement.Initialize(gameId, false);
        StartCoroutine(ShowBannerWhenReady());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }
    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(bannerid))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(bannerid);
    }
    public void SkipLvlAd()
    {
        if (Advertisement.IsReady(rewardVid))
        {
            var skipLvl = new ShowOptions { resultCallback = HandleShowResult2 };
            Advertisement.Show(rewardVid, skipLvl);
        }

    }
    public void GetFreeCoinsAd()
    {
        if (Advertisement.IsReady(rewardVid))
        {
            var giveCoinsResult = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show(rewardVid, giveCoinsResult);

        }
    }
    public void RandomAdChance()
    {
        if (Advertisement.IsReady(normalVid))
        {
            int randomizer = Random.Range(0, 110);
            if (randomizer > 97 && randomizer < 99)
            {
                Advertisement.Show(normalVid);
            }
        }
    }
    public void ShopPurchaseAd()
    {
        if (Advertisement.IsReady(rewardVid))
        {
            var shopPurchaseResult = new ShowOptions { resultCallback = HandleShowResult3 };
            Advertisement.Show(rewardVid, shopPurchaseResult);
        }
    }

    private void HandleShowResult(ShowResult giveCoinsResult)
    {
        switch (giveCoinsResult)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                coinLogic.coins += 50;
                saveSystem.SaveCoinsData();
                saveSystem.SaveLvlData();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
    private void HandleShowResult2(ShowResult skipLvl)
    {
        switch (skipLvl)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                saveSystem.SaveLvlData();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
        private void HandleShowResult3(ShowResult shopPurchaseResult)
    {
        switch (shopPurchaseResult)
        {
            case ShowResult.Finished:
                saveSystem.SaveWatchedAdData();
                Debug.Log("The ad was successfully shown.");
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }
}
