using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LineButtons : MonoBehaviour, IPointerClickHandler
{
    public bool isClicked = false;
    public bool isRightClick = false;
    public string ButtonName;
    public LineRenderer line;
    public List<Image> ImageList;
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("isRestart") == 1)
        {
            Debug.LogWarning("restartdoru");
            if (line!=null)
            {
                PlayerPrefs.SetInt("isButtonClosed", 1);
                Debug.LogWarning("saðclickdoru");
                isRightClick = true;
                
            }
            isClicked = false;
        }
    }

    //public void OnClick()
    //{
    //    isClicked = true;
    //}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left && this.GetComponent<Button>().interactable)
        {
            Debug.Log("Left click");
            isClicked = true;
        }
            
        else if (eventData.button == PointerEventData.InputButton.Middle && this.GetComponent<Button>().interactable)
            Debug.Log("Middle click");
        else if (eventData.button == PointerEventData.InputButton.Right && this.GetComponent<Button>().interactable)
        {
            Debug.Log("Right click");
            isRightClick = true;

        }
            
    }
}
