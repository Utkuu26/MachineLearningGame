using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContunieSystem : MonoBehaviour
{
    public GameObject level1Mission;
    public GameObject level1Hint;
    public GameObject level1GamePlay;
    public GameObject level2Mission;
    public GameObject level2Hint;
    public GameObject level2GamePlay;
    public GameObject level3Mission;
    public GameObject level3Hint;
    public GameObject level3GamePlay;
    public GameObject level4Mission;
    public GameObject level4GamePlay;
    public GameObject level5Mission;
    public GameObject level5Hint;
    public GameObject level5GamePlay;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level1Mission.activeInHierarchy || level1Hint.activeInHierarchy || level1GamePlay.activeInHierarchy)
        {
            PlayerPrefs.SetString("Level", "level1");
        }
        else if (level2Mission.activeInHierarchy || level2Hint.activeInHierarchy || level2GamePlay.activeInHierarchy)
        {
            PlayerPrefs.SetString("Level", "level2");
        }
        else if (level3Mission.activeInHierarchy || level3Hint.activeInHierarchy || level3GamePlay.activeInHierarchy)
        {
            PlayerPrefs.SetString("Level", "level3");
        }
        else if (level4Mission.activeInHierarchy || level4GamePlay.activeInHierarchy)
        {
            PlayerPrefs.SetString("Level", "level4");
        }
        else if (level5Mission.activeInHierarchy || level5Hint.activeInHierarchy || level5GamePlay.activeInHierarchy)
        {
            PlayerPrefs.SetString("Level", "level5");
        }

        if (PlayerPrefs.GetInt("isContunie")==1)
        {
            switch (PlayerPrefs.GetString("Level"))
            {
                case "level1":
                    level1Mission.SetActive(true);
                    PlayerPrefs.SetInt("isContunie", 0);
                    break;

                case "level2":
                    level2Mission.SetActive(true);
                    PlayerPrefs.SetInt("isContunie", 0);
                    break;

                case "level3":
                    level3Mission.SetActive(true);
                    PlayerPrefs.SetInt("isContunie", 0);
                    break;
                case "level4":
                    level4Mission.SetActive(true);
                    PlayerPrefs.SetInt("isContunie", 0);
                    break;
                case "level5":
                    level5Mission.SetActive(true);
                    PlayerPrefs.SetInt("isContunie", 0);
                    break;

                default:
                    PlayerPrefs.SetString("Level", null);
                    break;
            }
        }
    }

    public void RestartButton()
    {
        switch (PlayerPrefs.GetString("Level"))
        {
            case "level1":
                SceneManager.LoadScene(1);
                level1GamePlay.SetActive(true);
                
                break;

            case "level2":
                SceneManager.LoadScene(1);
                level2GamePlay.SetActive(true);
               
                break;

            case "level3":
                SceneManager.LoadScene(1);
                level3GamePlay.SetActive(true);
               
                break;
            case "level4":
                SceneManager.LoadScene(1);
                level4GamePlay.SetActive(true);
              
                break;
            case "level5":
                SceneManager.LoadScene(1);
                level5GamePlay.SetActive(true);
               
                break;

            default:
                PlayerPrefs.SetString("Level", null);
                break;
        }
    }
}
