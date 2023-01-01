using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMenuController : MonoBehaviour
{
    public GameObject hintScreen;
    public GameObject tutorialScreen;
    public GameObject tutorialScreenPlayButton;
    public GameObject level1Mission1Screen;
    public GameObject level1HintScreen;
    public GameObject level1GamePlayScreen;
    public GameObject level1GamePlayScreenÝnfoPanel;
    public GameObject level1MissionEndPanel;
    public GameObject level2Mission1Screen;
    public GameObject level2HintScreen;
    public GameObject level2GamePlayScreen;
    public GameObject level2GamePlayScreenÝnfoPanel;
    public GameObject level2MissionEndPanel;
    public GameObject level3Mission1Screen;
    public GameObject level3HintScreen;
    public GameObject level3GamePlayScreen;
    public GameObject level3GamePlayScreenÝnfoPanel;
    public GameObject level3MissionEndPanel;
    public GameObject level4Mission1Screen;
    public GameObject level4GamePlayScreen;
    //public GameObject level4GamePlayScreenÝnfoPanel;
    //public GameObject level4MissionEndPanel;
    public GameObject level5Mission1Screen;
    public GameObject level5HintScreen;
    public GameObject level5GamePlayScreen;
    public GameObject level5GamePlayScreenÝnfoPanel;
    public GameObject level5MissionEndPanel;
    public GameObject theEndPanel;
    public bool isLevelCompleted;
    public CreateLine cl;
    public AudioSource _as;
    public AudioSource _asReward;

    private void Awake()
    {
        _as = GetComponent<AudioSource>();
    }
    public IEnumerator waitin()
    {
        _as.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        //isLevelCompleted = true; // kablo baðlantýsý yaptýðým yerde kontrol edip oraya geçiricem
         // üsttekinin aynýsý
    }

    // Update is called once per frame
    void Update()
    {
        isLevelCompleted = cl.isRun;
        IsTutorialLevelCompleted(isLevelCompleted);
    }

    public void HomeButton()
    {
        StartCoroutine("waitin");
    }

    public void OpenTutorialScreen()
    {
        _as.Play();
        hintScreen.SetActive(false);
        tutorialScreen.SetActive(true);
    }

    public void OpenHintScreen()
    {
        _as.Play();
        hintScreen.SetActive(true);
        tutorialScreen.SetActive(false);
    }

    public void IsTutorialLevelCompleted(bool IsCompleted)
    {
        if (IsCompleted)
        {
            tutorialScreenPlayButton.SetActive(true);
        }
        else
        {
            tutorialScreenPlayButton.SetActive(false);
        }
    }

    public void PlayButton()
    {
        tutorialScreen.SetActive(false);
        level1Mission1Screen.SetActive(true);
    }

    public void OpenLevel1HintScreen()
    {
        _as.Play();
        level1HintScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1BackToTutorialScreen()
    {  //level 1mission screendeki back
        _as.Play();
        tutorialScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1BackToMissionScreen()
    { // level1 hint screendeki back
        _as.Play();
        level1HintScreen.SetActive(false);
        level1Mission1Screen.SetActive(true);
    }

    public void Level1OpenGamePlayScreen()
    {
        _as.Play();
        level1GamePlayScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1OpenInfoPanel()
    {
        _as.Play();
        level1GamePlayScreenÝnfoPanel.SetActive(true);

    }

    public void Level1CloseInfoPanel()
    {
        _as.Play();
        level1GamePlayScreenÝnfoPanel.SetActive(false);

    }

    public void LevelHintPanel1Url1()
    {
        _as.Play();
        Application.OpenURL("https://medium.com/biliþim-hareketi/python-ile-ses-tanýma-uygulamasý-oluþturma-3d0d972c62a6");
    }

    public void LevelHintPanel1Url2()
    {
        _as.Play();
        Application.OpenURL("https://arxiv.org/abs/2108.09203");
    }

    public void LevelHintPanel1Url3()
    {
        _as.Play();
        Application.OpenURL("https://www.youtube.com/watch?v=iCwMQJnKk2c&list=PL-wATfeyAMNqIee7cH3q1bh4QJFAaeNv0");
    }

    // level 1 win koþulu yazýp level1runcompl panelini açmalýsýn
    public void Level1CompletedButton()
    {
        PlayerPrefs.SetInt("Coin", 250);
        _asReward.Play();
        level1GamePlayScreen.SetActive(false);
        level1MissionEndPanel.SetActive(true);
    }

    public void Level1MissionEndPanelOkButton()
    {
        _as.Play();
        level1MissionEndPanel.SetActive(false);
        level2Mission1Screen.SetActive(true);
    }

    public void level2MissonScreenBack()
    {
        _as.Play();
        level2Mission1Screen.SetActive(false);
        level1MissionEndPanel.SetActive(true);
        
    }

    public void Level2MissionScreenOkBtn()
    {
        _as.Play();
        level2Mission1Screen.SetActive(false);
        level2GamePlayScreen.SetActive(true);
    }

    public void level2MissionScreenInfoPanel()
    {
        _as.Play();
        level2Mission1Screen.SetActive(false);
        level2HintScreen.SetActive(true);
    }

    public void level2HintScreenBackBtn()
    {
        _as.Play();
        level2HintScreen.SetActive(false);
        level2Mission1Screen.SetActive(true);
    }

    public void level2GameplaySceneInfoBtn()
    {
        _as.Play();
        level2GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level2GameplaySceneCloseInfoBtn()
    {
        _as.Play();
        level2GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void Level2HintPanelUrl1()
    {
        _as.Play();
        Application.OpenURL("https://www.youtube.com/watch?v=T_Fn_CBA8bI&list=PLTdWDQRIESbZ-m3JdELFWmmhv6EF0G3fs");
    }

    public void Level2HintPanelUrl2()
    {
        _as.Play();
        Application.OpenURL("https://www.sciencedirect.com/science/article/abs/pii/S0360131518303191");
    }

    public void Level2HintPanelUrl3()
    {
        _as.Play();
        Application.OpenURL("https://simulatoran.com/machine-learning-models-for-prediction/");
    }

    public void level2RunCompleteOkBtn()
    {
        PlayerPrefs.SetInt("Coin", 600);
        _asReward.Play();
        level2GamePlayScreen.SetActive(false);
        level2MissionEndPanel.SetActive(true);
    }

    public void Level2MissionEndPanelOkButton()
    {
        _as.Play();
        level2MissionEndPanel.SetActive(false);
        level3Mission1Screen.SetActive(true);
    }

    public void level3MissonScreenBack()
    {
        _as.Play();
        level3Mission1Screen.SetActive(false);
        level2MissionEndPanel.SetActive(true);

    }

    public void Level3MissionScreenOkBtn()
    {
        _as.Play();
        level3Mission1Screen.SetActive(false);
        level3GamePlayScreen.SetActive(true);
    }

    public void level3MissionScreenInfoPanel()
    {
        _as.Play();
        level3Mission1Screen.SetActive(false);
        level3HintScreen.SetActive(true);
    }

    public void level3HintScreenBackBtn()
    {
        _as.Play();
        level3HintScreen.SetActive(false);
        level3Mission1Screen.SetActive(true);
    }

    public void level3GameplaySceneInfoBtn()
    {
        _as.Play();
        level3GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level3GameplaySceneCloseInfoBtn()
    {
        _as.Play();
        level3GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void Level3HintPanelUrl1()
    {
        _as.Play();
        Application.OpenURL("https://www.youtube.com/watch?v=BnOTv0f9Msk");
    }

    public void Level3HintPanelUrl2()
    {
        _as.Play();
        Application.OpenURL("https://neptune.ai/blog/must-do-error-analysis");
    }

    public void Level3HintPanelUrl3()
    {
        _as.Play();
        Application.OpenURL("https://aip.scitation.org/doi/abs/10.1063/1.1597683");
    }

    public void level3RunCompleteOkBtn()
    {
        PlayerPrefs.SetInt("Coin", 1050);
        _asReward.Play();
        level3GamePlayScreen.SetActive(false);
        level3MissionEndPanel.SetActive(true);
    }

    public void Level3MissionEndPanelOkButton()
    {
        _as.Play();
        level3MissionEndPanel.SetActive(false);
        level4Mission1Screen.SetActive(true);
    }

    public void level4MissonScreenBack()
    {
        _as.Play();
        level4Mission1Screen.SetActive(false);
        level3MissionEndPanel.SetActive(true);

    }

    public void Level4MissionScreenOkBtn()
    {
        _as.Play();
        level4Mission1Screen.SetActive(false);
        level4GamePlayScreen.SetActive(true);
    }

    public void level4RunCompleteOkBtn()
    {
        PlayerPrefs.SetInt("Coin", 1500);
        _asReward.Play();
        level4GamePlayScreen.SetActive(false);
        level5Mission1Screen.SetActive(true);
    }

    public void level5MissonScreenBack()
    {
        _as.Play();
        level5Mission1Screen.SetActive(false);
        level4GamePlayScreen.SetActive(true); // buraya neler öðrendim ekleyip oraya döndürmek daha mantýklý

    }

    public void Level5MissionScreenOkBtn()
    {
        _as.Play();
        level5Mission1Screen.SetActive(false);
        level5GamePlayScreen.SetActive(true);
    }

    public void level5MissionScreenInfoPanel()
    {
        _as.Play();
        level5Mission1Screen.SetActive(false);
        level5HintScreen.SetActive(true);
    }

    public void level5HintScreenBackBtn()
    {
        _as.Play();
        level5HintScreen.SetActive(false);
        level5Mission1Screen.SetActive(true);
    }

    public void Level5HintPanelUrl1()
    {
        _as.Play();
        Application.OpenURL("https://www.youtube.com/watch?v=_L39rN6gz7Y");
    }

    public void Level5HintPanelUrl2()
    {
        _as.Play();
        Application.OpenURL("https://towardsdatascience.com/decision-trees-in-machine-learning-641b9c4e8052");
    }

    public void Level5HintPanelUrl3()
    {
        _as.Play();
        Application.OpenURL("https://developers.google.com/machine-learning/decision-forests/decision-trees");
    }

    public void level5GameplaySceneInfoBtn()
    {
        _as.Play();
        level5GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level5GameplaySceneCloseInfoBtn()
    {
        _as.Play();
        level5GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void level5RunCompleteOkBtn()
    {
        PlayerPrefs.SetInt("Coin", 2100);
        _asReward.Play();
        level5GamePlayScreen.SetActive(false);
        level5MissionEndPanel.SetActive(true);
    }

    public void Level5MissionEndScreenOkBtn()
    {
        _as.Play();
        level5MissionEndPanel.SetActive(false);
        theEndPanel.SetActive(true);
    }

    public void TheEndScrrenToMainMenu()
    {
        _as.Play();
        theEndPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }


}
