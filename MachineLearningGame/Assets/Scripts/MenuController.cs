using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject nickNamePanel;
    public GameObject mainMenuPanel;
    public AudioSource _as;
 

    void Start()
    {
        
    }

    private void Awake()
    {
        _as = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNickNamePanel()
    {
        _as.Play();
        mainMenuPanel.SetActive(false);
        nickNamePanel.SetActive(true);
        
    }
    public void Play()
    {
        
        StartCoroutine("waitin");
        
    }

    public void HomeButton()
    {
        _as.Play();
        mainMenuPanel.SetActive(true);
        nickNamePanel.SetActive(false);
    }

    public void QuitButton()
    {
        _as.Play();
        Application.Quit();
    }

    public IEnumerator waitin()
    {
        _as.Play();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(1);
    }

   

}
