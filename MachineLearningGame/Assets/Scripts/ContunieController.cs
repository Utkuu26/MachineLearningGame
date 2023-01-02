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
            contBtn.enabled = false;
            contBtnUp.enabled = false;
        }
        else
        {
            contBtn.enabled = true;
            contBtnUp.enabled = true;
        }
    }

    public void ContunieButtonClick()
    {
        PlayerPrefs.SetInt("isContunie", 1);
        SceneManager.LoadScene(1);
    }
}
