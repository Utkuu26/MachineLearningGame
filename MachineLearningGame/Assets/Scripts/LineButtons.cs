using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class LineButtons : MonoBehaviour, IPointerClickHandler
{
    public bool isClicked = false;
    public bool isRightClick = false;
    public bool hasDropdown;
    public bool isLevel5;
    public string ButtonName;
    public TMP_Dropdown dropdown;
    public TMP_Dropdown dropdown1;
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
            if (hasDropdown)
            {
                dropdown.SetValueWithoutNotify(0);
                if (isLevel5)
                {
                    dropdown1.SetValueWithoutNotify(0);
                }

            }
            Debug.LogWarning("restartdoru");
            if (line!=null)
            {
                PlayerPrefs.SetInt("isButtonClosed", 1);
                Debug.LogWarning("sa?clickdoru");
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
