using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public bool restart=false;
    public List<Button> level1GamePlayButtons;
    public List<Button> leve21GamePlayButtons;
    public List<Button> leve31GamePlayButtons;
    public List<Button> leve41GamePlayButtons;
    public List<Button> leve51GamePlayButtons;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RestartButtonclick()
    {
        PlayerPrefs.SetInt("isRestart", 1);
        restart = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning((PlayerPrefs.GetString("Level")));
        if (PlayerPrefs.GetInt("isRestart") == 1)
        {

            switch (PlayerPrefs.GetString("Level"))
            {
                case "level1":
                    // SceneManager.LoadScene(1);
                    Debug.Log("REstart");
                    if (PlayerPrefs.GetInt("isButtonClosed")==1)
                    {
                        PlayerPrefs.SetInt("isRestart", 0);
                        PlayerPrefs.SetInt("isButtonClosed", 0);

                    }

                    break;

                case "level2":
                    //SceneManager.LoadScene(1);

                    if (PlayerPrefs.GetInt("isButtonClosed") == 1)
                    {
                        PlayerPrefs.SetInt("isRestart", 0);
                        PlayerPrefs.SetInt("isButtonClosed", 0);

                    }

                    break;

                case "level3":
                    // SceneManager.LoadScene(1);

                    if (PlayerPrefs.GetInt("isButtonClosed") == 1)
                    {
                        PlayerPrefs.SetInt("isRestart", 0);
                        PlayerPrefs.SetInt("isButtonClosed", 0);

                    }

                    break;
                case "level4":
                    //SceneManager.LoadScene(1);

                    if (PlayerPrefs.GetInt("isButtonClosed") == 1)
                    {
                        PlayerPrefs.SetInt("isRestart", 0);
                        PlayerPrefs.SetInt("isButtonClosed", 0);

                    }

                    break;
                case "level5":
                    //SceneManager.LoadScene(1);

                    if (PlayerPrefs.GetInt("isButtonClosed") == 1)
                    {
                        PlayerPrefs.SetInt("isRestart", 0);
                        PlayerPrefs.SetInt("isButtonClosed", 0);

                    }

                    break;

              
            }
        }
    }
}
