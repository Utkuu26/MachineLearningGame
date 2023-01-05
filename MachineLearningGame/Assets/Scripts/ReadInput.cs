using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public InputField nickNameInput;
    public AudioSource _as;
    public Button play;
    public Button playBig;
    void Start()
    {
        play.interactable = false;
        playBig.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        _as = GetComponent<AudioSource>();
    }


    public void EndEdit()
     {
        Debug.Log(nickNameInput.text);
        PlayerPrefs.SetString("NickName", nickNameInput.text);
        play.interactable = true;
        playBig.interactable = true;
    }

     public void ButtonClick()
     {
        _as.Play();
        Debug.Log(nickNameInput.text);
        PlayerPrefs.SetString("NickName", nickNameInput.text);
        play.interactable = true;
        playBig.interactable = true;
    }


}
