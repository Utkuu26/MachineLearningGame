using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLine : MonoBehaviour
{
    public LineRenderer line;
    public Transform redConn1;
    public Transform redConn2;
    public Transform orangeConn1;
    public Transform orangeConn2;
    public Transform orangeConn3;
    public Transform orangeConn4;
    public Transform orangeConn5;
    public Transform orangeConn6;
    public List<Button> StartButtons;
    public List<Button> EndButtons;
    public Transform startTransform;
    public Transform endTransform;
    public int turn=0;
    void Start()
    {
        line.positionCount = 2;
        foreach (var item in EndButtons)
        {
            item.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (turn%2==0)
        {
            foreach (var item in EndButtons)
            {
                item.GetComponent<LineButtons>().isClicked = false;
            }
            foreach (var item in StartButtons)
            {
                if (item.GetComponent<LineButtons>().isClicked)
                {
                   
                    startTransform = item.transform;
                    turn++;
                    foreach (var endbtn in EndButtons)
                    {
                        endbtn.enabled = true;
                    }
                    foreach (var startbtn in StartButtons)
                    {
                        startbtn.enabled = false;
                    }
                }

                if (item.GetComponent<LineButtons>().isRightClick)
                {
                    line.enabled = false;
                    item.GetComponent<LineButtons>().isRightClick = false;
                }
            }

           
        }

        else
        {
            foreach (var item in StartButtons)
            {
                item.GetComponent<LineButtons>().isClicked = false;
            }
            foreach (var item in EndButtons)
            {
                if (item.GetComponent<LineButtons>().isClicked)
                {
                    endTransform = item.transform;
                    turn++;
                    foreach (var endbtn in EndButtons)
                    {
                        endbtn.enabled = false;
                    }
                    foreach (var startbtn in StartButtons)
                    {
                        startbtn.enabled = true;
                    }
                }
            }   

            if (startTransform!=null && endTransform!=null)
            {
                CreateLines(startTransform, endTransform);
                line.enabled = true;
                startTransform = null;
                endTransform = null;
             
            }
        }

      

    }

    public void CreateLines(Transform startTransform, Transform endTrasnform)
    {
        line.SetPosition(0, startTransform.position + new Vector3(0,0,-3f));
        line.SetPosition(1, endTrasnform.position + new Vector3(0, 0, -3f));
     
        
        

    }
}
