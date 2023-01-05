using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetNickNamePlayScene : MonoBehaviour
{
    
    public List<TextMeshProUGUI> nickNameList;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in nickNameList)
        {
            item.text = PlayerPrefs.GetString("NickName");
        }
    }
}
