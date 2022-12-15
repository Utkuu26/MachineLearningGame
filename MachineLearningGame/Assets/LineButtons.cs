using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LineButtons : MonoBehaviour, IPointerClickHandler
{
    public bool isClicked = false;
    public bool isRightClick = false;
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //public void OnClick()
    //{
    //    isClicked = true;
    //}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left click");
            isClicked = true;
        }
            
        else if (eventData.button == PointerEventData.InputButton.Middle)
            Debug.Log("Middle click");
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right click");
            isRightClick = true;

        }
            
    }
}
