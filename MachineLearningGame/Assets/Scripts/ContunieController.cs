using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContunieController : MonoBehaviour
{
    public Button contBtn;
    public Button contBtnUp;
    void Update()
    {
        if (PlayerPrefs.GetString("Level") == "")
        {
            contBtn.interactable = false;
            contBtnUp.interactable = false;
        }
        else
        {
            contBtn.interactable = true;
            contBtnUp.interactable = true;
        }
    }

    public void ContunieButtonClick()
    {
        PlayerPrefs.SetInt("isContunie", 1);
        SceneManager.LoadScene(1);
    }
}
