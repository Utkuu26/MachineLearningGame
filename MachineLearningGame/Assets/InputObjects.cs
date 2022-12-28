using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputObjects : MonoBehaviour
{
    public float speed = 2f;
    public Transform nextPos;
    public List<Transform> nextPoses;
    //dizi tut
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MoveImg(nextPoses);
    }

    //public void MoveImg(List<Transform> nextPoses)
    //{
    //    int i = 0;
    //    if (this.transform.position != nextPoses[i].position)
    //    {
    //        this.transform.position = Vector3.MoveTowards(this.transform.position, nextPoses[i].position, speed * Time.deltaTime);
    //        Debug.Log(this.transform.position + " " + nextPoses[i].position);

    //    }

    //    if (Vector3.Distance(this.transform.position, nextPoses[i].position)<0.5f)
    //    {

    //        this.GetComponent<Image>().enabled = !this.GetComponent<Image>().enabled;
    //        i++;
    //        if (nextPoses.Count-1 == i)
    //        {
    //            Destroy(this);
    //        }
    //        // indeks toplama eþitse sil objeyi
            
    //    }
    //}
}
