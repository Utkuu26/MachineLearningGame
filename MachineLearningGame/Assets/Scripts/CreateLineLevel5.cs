using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLineLevel5 : MonoBehaviour
{
    public LineRenderer line;
    public List<Button> EndButtons;
    public List<Button> EndButtonsOutputPanel;
    public List<Button> StartButtonsIfPanel;
    public List<Button> StartButtonsDecisition;
    public List<Button> StartButtonTrash;
    public Transform startTransform;
    public Transform endTransform;
    public string StartButtonName;
    public string EndButtonName;
    public int turn = 0;
    public float speed;
    public AudioSource _asCreateLine;
    public AudioSource _asDestroyLine;
    public Button StartButton;
    void Start()
    {
        line.positionCount = 2;
        foreach (var item in EndButtons)
        {
            item.interactable = false;
        }
        speed = 5;

    }

    void Update()
    {
        if (turn%2==0)
        {
            if (StartButton.GetComponent<LineButtons>().isClicked)
            {
                startTransform = StartButton.transform.GetChild(1);
                turn++;
                foreach (var item in EndButtons)
                {
                    item.interactable = true;
                }
            }
            
            for (int i = 0; i < StartButtonsIfPanel.Count; i++)
            {
                if (StartButtonsIfPanel[i].GetComponent<LineButtons>().isClicked)
                {
                    StartButtonName = StartButtonsIfPanel[i].GetComponent<LineButtons>().ButtonName;
                    EndButtonsOutputPanel[i].interactable = true;
                    startTransform = StartButtonsIfPanel[i].transform.GetChild(1);
                }
            }

            for (int i = 0; i < StartButtonsDecisition.Count; i++)
            {
                if (StartButtonsDecisition[i].GetComponent<LineButtons>().isClicked)
                {
                    StartButtonName = StartButtonsDecisition[i].GetComponent<LineButtons>().ButtonName;
                    EndButtonsOutputPanel[i].interactable = true;
                    startTransform = StartButtonsDecisition[i].transform.GetChild(1);
                }
            }

        }

        else
        {
          
            foreach (var item in EndButtons)
            {
                if (item.GetComponent<LineButtons>().isClicked)
                {
                    EndButtonName = item.GetComponent<LineButtons>().ButtonName;
                    endTransform = item.transform.GetChild(1);
                    turn++;
                    foreach (var endbtn in EndButtons)
                    {
                        endbtn.interactable = false;
                    }
                    if (EndButtonName == "EndIf1")
                    {
                        foreach (var startbtn in StartButtonsIfPanel)
                        {
                            startbtn.interactable = true;
                        }
                    }
                    else if (EndButtonName == "EndDecision1")
                    {
                        foreach (var startbtn in StartButtonsDecisition)
                        {
                            startbtn.interactable = true;
                        }
                    }
                    else if (EndButtonName == "EndTrash1")
                    {
                       //Oyunu baþlat bitir.
                    }
                   
                }
            }

            if (startTransform != null && endTransform != null)
            {
                if (turn==1)
                {
                    Debug.Log("mal 1 de yim ");
                    CreateLines(startTransform, endTransform, StartButton.GetComponent<LineButtons>().line);
                    StartButton.GetComponent<LineButtons>().line.enabled = true;
                    startTransform = null;
                    endTransform = null;
                }
                else
                {
                    foreach (var item in StartButtonsIfPanel)
                    {
                        if (StartButtonName == item.GetComponent<LineButtons>().ButtonName)
                        {
                            _asCreateLine.Play();
                            CreateLines(startTransform, endTransform, item.GetComponent<LineButtons>().line);
                            item.GetComponent<LineButtons>().line.enabled = true;

                        }
                    }
                    foreach (var item in StartButtonsDecisition)
                    {
                        if (StartButtonName == item.GetComponent<LineButtons>().ButtonName)
                        {
                            _asCreateLine.Play();
                            CreateLines(startTransform, endTransform, item.GetComponent<LineButtons>().line);
                            item.GetComponent<LineButtons>().line.enabled = true;

                        }
                    }

                    startTransform = null;
                    endTransform = null;

                }
                       

            }
        }





    }

    public void CreateLines(Transform startTransform, Transform endTrasnform, LineRenderer line)
    {
        line.SetPosition(0, startTransform.position + new Vector3(0, 0, -3f));
        line.SetPosition(1, endTrasnform.position + new Vector3(0, 0, -3f));

    }



}
