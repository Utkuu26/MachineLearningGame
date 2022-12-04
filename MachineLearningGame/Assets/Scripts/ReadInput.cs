using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public InputField nickNameInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void EndEdit()
     {
        Debug.Log(nickNameInput.text);
        PlayerPrefs.SetString("NickName", nickNameInput.text);
     }

     public void ButtonClick()
     {
        Debug.Log(nickNameInput.text);
        PlayerPrefs.SetString("NickName", nickNameInput.text);
    }


}
