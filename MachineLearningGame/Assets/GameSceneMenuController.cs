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





}
