using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject nickNamePanel;
    public GameObject mainMenuPanel;
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNickNamePanel()
    {
        mainMenuPanel.SetActive(false);
        nickNamePanel.SetActive(true);
        
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        mainMenuPanel.SetActive(true);
        nickNamePanel.SetActive(false);
    }

   

}
