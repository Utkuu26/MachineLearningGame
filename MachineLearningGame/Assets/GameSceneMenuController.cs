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
    public GameObject level1GamePlayScreen�nfoPanel;
    public bool isLevelCompleted;
    void Start()
    {
        isLevelCompleted = true; // kablo ba�lant�s� yapt���m yerde kontrol edip oraya ge�iricem
        IsTutorialLevelCompleted(isLevelCompleted); // �sttekinin ayn�s�
    }

    // Update is called once per frame
    void Update()
    {
        
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
        level1GamePlayScreen�nfoPanel.SetActive(true);

    }

    public void Level1CloseInfoPanel()
    {
        level1GamePlayScreen�nfoPanel.SetActive(false);

    }





}
