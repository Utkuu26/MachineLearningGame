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
    public bool isLevelCompleted;
    public CreateLine cl;
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
        SceneManager.LoadScene(0);
    }

    public void OpenTutorialScreen()
    {
        hintScreen.SetActive(false);
        tutorialScreen.SetActive(true);
    }

    public void OpenHintScreen()
    {
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
        level1HintScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1BackToTutorialScreen()
    {  //level 1mission screendeki back
        tutorialScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1BackToMissionScreen()
    { // level1 hint screendeki back
        level1HintScreen.SetActive(false);
        level1Mission1Screen.SetActive(true);
    }

    public void Level1OpenGamePlayScreen()
    { 
        level1GamePlayScreen.SetActive(true);
        level1Mission1Screen.SetActive(false);
    }

    public void Level1OpenInfoPanel()
    {
        level1GamePlayScreenÝnfoPanel.SetActive(true);

    }

    public void Level1CloseInfoPanel()
    {
        level1GamePlayScreenÝnfoPanel.SetActive(false);

    }

    public void LevelHintPanel1Url1()
    {
        Application.OpenURL("https://medium.com/biliþim-hareketi/python-ile-ses-tanýma-uygulamasý-oluþturma-3d0d972c62a6");
    }

    public void LevelHintPanel1Url2()
    {
        Application.OpenURL("https://arxiv.org/abs/2108.09203");
    }

    public void LevelHintPanel1Url3()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=iCwMQJnKk2c&list=PL-wATfeyAMNqIee7cH3q1bh4QJFAaeNv0");
    }

    // level 1 win koþulu yazýp level1runcompl panelini açmalýsýn
    public void Level1CompletedButton()
    {
        level1GamePlayScreen.SetActive(false);
        level1MissionEndPanel.SetActive(true);
    }

    public void Level1MissionEndPanelOkButton()
    {
        level1MissionEndPanel.SetActive(false);
        level2Mission1Screen.SetActive(true);
    }

    public void level2MissonScreenBack()
    {
        level2Mission1Screen.SetActive(false);
        level1MissionEndPanel.SetActive(true);
        
    }

    public void Level2MissionScreenOkBtn()
    {
        level2Mission1Screen.SetActive(false);
        level2GamePlayScreen.SetActive(true);
    }

    public void level2MissionScreenInfoPanel()
    {
        level2Mission1Screen.SetActive(false);
        level2HintScreen.SetActive(true);
    }

    public void level2HintScreenBackBtn()
    {
        level2HintScreen.SetActive(false);
        level2Mission1Screen.SetActive(true);
    }

    public void level2GameplaySceneInfoBtn()
    {
        level2GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level2GameplaySceneCloseInfoBtn()
    {
        level2GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void Level2HintPanelUrl1()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=T_Fn_CBA8bI&list=PLTdWDQRIESbZ-m3JdELFWmmhv6EF0G3fs");
    }

    public void Level2HintPanelUrl2()
    {
        Application.OpenURL("https://www.sciencedirect.com/science/article/abs/pii/S0360131518303191");
    }

    public void Level2HintPanelUrl3()
    {
        Application.OpenURL("https://simulatoran.com/machine-learning-models-for-prediction/");
    }

    public void level2RunCompleteOkBtn()
    {
        level2GamePlayScreen.SetActive(false);
        level2MissionEndPanel.SetActive(true);
    }

    public void Level2MissionEndPanelOkButton()
    {
        level2MissionEndPanel.SetActive(false);
        level3Mission1Screen.SetActive(true);
    }

    public void level3MissonScreenBack()
    {
        level3Mission1Screen.SetActive(false);
        level2MissionEndPanel.SetActive(true);

    }

    public void Level3MissionScreenOkBtn()
    {
        level3Mission1Screen.SetActive(false);
        level3GamePlayScreen.SetActive(true);
    }

    public void level3MissionScreenInfoPanel()
    {
        level3Mission1Screen.SetActive(false);
        level3HintScreen.SetActive(true);
    }

    public void level3HintScreenBackBtn()
    {
        level3HintScreen.SetActive(false);
        level3Mission1Screen.SetActive(true);
    }

    public void level3GameplaySceneInfoBtn()
    {
        level3GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level3GameplaySceneCloseInfoBtn()
    {
        level3GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void Level3HintPanelUrl1()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=BnOTv0f9Msk");
    }

    public void Level3HintPanelUrl2()
    {
        Application.OpenURL("https://neptune.ai/blog/must-do-error-analysis");
    }

    public void Level3HintPanelUrl3()
    {
        Application.OpenURL("https://aip.scitation.org/doi/abs/10.1063/1.1597683");
    }

    public void level3RunCompleteOkBtn()
    {
        level3GamePlayScreen.SetActive(false);
        level3MissionEndPanel.SetActive(true);
    }

    public void Level3MissionEndPanelOkButton()
    {
        level3MissionEndPanel.SetActive(false);
        level4Mission1Screen.SetActive(true);
    }

    public void level4MissonScreenBack()
    {
        level4Mission1Screen.SetActive(false);
        level3MissionEndPanel.SetActive(true);

    }

    public void Level4MissionScreenOkBtn()
    {
        level4Mission1Screen.SetActive(false);
        level4GamePlayScreen.SetActive(true);
    }

    public void level4RunCompleteOkBtn()
    {
        level4GamePlayScreen.SetActive(false);
        level5Mission1Screen.SetActive(true);
    }

    public void level5MissonScreenBack()
    {
        level5Mission1Screen.SetActive(false);
        level4GamePlayScreen.SetActive(true); // buraya neler öðrendim ekleyip oraya döndürmek daha mantýklý

    }

    public void Level5MissionScreenOkBtn()
    {
        level5Mission1Screen.SetActive(false);
        level5GamePlayScreen.SetActive(true);
    }

    public void level5MissionScreenInfoPanel()
    {
        level5Mission1Screen.SetActive(false);
        level5HintScreen.SetActive(true);
    }

    public void level5HintScreenBackBtn()
    {
        level5HintScreen.SetActive(false);
        level5Mission1Screen.SetActive(true);
    }

    public void Level5HintPanelUrl1()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=_L39rN6gz7Y");
    }

    public void Level5HintPanelUrl2()
    {
        Application.OpenURL("https://towardsdatascience.com/decision-trees-in-machine-learning-641b9c4e8052");
    }

    public void Level5HintPanelUrl3()
    {
        Application.OpenURL("https://developers.google.com/machine-learning/decision-forests/decision-trees");
    }

    public void level5GameplaySceneInfoBtn()
    {
        level5GamePlayScreenÝnfoPanel.SetActive(true);
    }
    public void level5GameplaySceneCloseInfoBtn()
    {
        level5GamePlayScreenÝnfoPanel.SetActive(false);
    }

    public void level5RunCompleteOkBtn()
    {
        level5GamePlayScreen.SetActive(false);
        level5MissionEndPanel.SetActive(true);
    }

    public void Level5MissionEndScreenOkBtn()
    {
        level5MissionEndPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }


}
