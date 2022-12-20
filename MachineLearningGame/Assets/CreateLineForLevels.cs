using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLineForLevels : MonoBehaviour
{
    public LineRenderer line;
    public List<Button> StartButtons;
    public List<Button> EndButtons;
    //public List<Image> ImageList;
    public Transform startTransform;
    public Transform endTransform;
    public GameObject cube;
    public string StartButtonName;
    public int turn = 0;
    public float speed;
    public Image Electricy;
    public bool isRun = false;
    public bool isLinesActive = false;
    void Start()
    {
        line.positionCount = 2;
        foreach (var item in EndButtons)
        {
            item.interactable = false;
        }
        speed = 5;

    }

    // Update is called once per frame
    void Update()
    {
        //if (StartButtons[0].GetComponent<LineButtons>().line.enabled && StartButtons[1].GetComponent<LineButtons>().line.enabled
        //    && StartButtons[2].GetComponent<LineButtons>().line.enabled && StartButtons[3].GetComponent<LineButtons>().line.enabled)
        //{
        //    isLinesActive = true;
        //}
        //if (isLinesActive)
        //{
        //    StartCoroutine(MoveGameObject(StartButtons[0].GetComponent<LineButtons>().ImageList, EndButtons[0].transform.GetChild(1)));
        //    StartCoroutine(MoveGameObject(StartButtons[1].GetComponent<LineButtons>().ImageList, EndButtons[1].transform.GetChild(1)));
        //    StartCoroutine(MoveGameObject(StartButtons[2].GetComponent<LineButtons>().ImageList, EndButtons[2].transform.GetChild(1)));
        //    StartCoroutine(MoveGameObject(StartButtons[3].GetComponent<LineButtons>().ImageList, EndButtons[3].transform.GetChild(1)));
        //    isRun = true;
        //    //MoveGameObject(Electricy, EndButtons[0].transform);
        //}

        if (turn % 2 == 0)
        {
            foreach (var item in EndButtons)
            {
                item.GetComponent<LineButtons>().isClicked = false;
            }
            foreach (var item in StartButtons)
            {
                if (item.GetComponent<LineButtons>().isClicked)
                {

                    StartButtonName = item.GetComponent<LineButtons>().ButtonName;
                    startTransform = item.transform.GetChild(1);
                    turn++;
                    //foreach (var endbtn in EndButtons)
                    //{
                    //    endbtn.enabled = true;
                    //}
                    for (int i = 0; i < StartButtons.Count; i++)
                    {
                        if (StartButtonName == StartButtons[i].GetComponent<LineButtons>().ButtonName)
                        {
                            EndButtons[i].interactable = true;
                        }
                    }
                    foreach (var startbtn in StartButtons)
                    {
                        startbtn.interactable = false;
                    }
                }

                if (item.GetComponent<LineButtons>().isRightClick)
                {
                    item.GetComponent<LineButtons>().line.enabled = false;
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
                    endTransform = item.transform.GetChild(1);
                    turn++;
                    foreach (var endbtn in EndButtons)
                    {
                        endbtn.interactable = false;
                    }
                    foreach (var startbtn in StartButtons)
                    {
                        startbtn.interactable = true;
                    }
                }
            }

            if (startTransform != null && endTransform != null)
            {
                foreach (var item in StartButtons)
                {
                    if (StartButtonName == item.GetComponent<LineButtons>().ButtonName)
                    {
                        CreateLines(startTransform, endTransform, item.GetComponent<LineButtons>().line);
                        item.GetComponent<LineButtons>().line.enabled = true;

                    }
                }


                startTransform = null;
                endTransform = null;

            }
        }



    }

    public void CreateLines(Transform startTransform, Transform endTrasnform, LineRenderer line)
    {
        line.SetPosition(0, startTransform.position + new Vector3(0, 0, -3f));
        line.SetPosition(1, endTrasnform.position + new Vector3(0, 0, -3f));
        //cube.GetComponent<Rigidbody>().MovePosition(EndButtons[0].transform.position);

    }

    //IEnumerator MoveGameObject(List<Image> imgList, Transform nextPos)
    //{
       
    //    for (int j = 0; j < imgList.Count; j++)
    //    {

    //        if (imgList[j].transform.position != nextPos.position)
    //        {
    //            imgList[j].transform.position = Vector3.MoveTowards(imgList[j].transform.position, nextPos.position, speed * Time.deltaTime);
    //            yield return new WaitForSecondsRealtime(2f);
    //        }

    //        if (imgList[j].transform.position == nextPos.position)
    //        {
    //            imgList[j].enabled = false;
    //        }

    //    }


    //}


}
