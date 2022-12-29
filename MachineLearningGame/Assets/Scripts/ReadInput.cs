using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public InputField nickNameInput;
    public AudioSource _as;
    void Start()
    {
        
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
     }

     public void ButtonClick()
     {
        _as.Play();
        Debug.Log(nickNameInput.text);
        PlayerPrefs.SetString("NickName", nickNameInput.text);
    }


}
