using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputObjects : MonoBehaviour
{
    public float speed = 2f;
    public Transform nextPos;
    public List<Transform> nextPoses;
    public TextMeshProUGUI destroyedObjectsText;
    public List<GameObject> OutputGameObjects;
    public List<GameObject> OutputGameObjects1;
    public int i = 0;
    public bool isContinue;
    public bool isTrash;
    //dizi tut
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveImg(nextPoses);
    }

    public void MoveImg(List<Transform> nextPoses)
    {    Debug.Log(this.transform.position + " " + nextPoses[i].position);
        if (this.transform.position != nextPoses[i].position)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, nextPoses[i].position, speed * Time.deltaTime);
            //Debug.Log(this.transform.position + " " + nextPoses[i].position);
            Debug.Log("devamke");

        }
      //  Vector3.Distance(this.transform.position, nextPoses[i].position) < 1

        if (Vector3.Distance(this.transform.position, nextPoses[i].position) < 1 && isContinue)
        {
            
           
            this.GetComponent<Image>().enabled = !this.GetComponent<Image>().enabled;
            i++;
            isContinue = false;
            Debug.Log(i + "d?ng? 1 daki i");
            if (nextPoses.Count == i)
            {
                //Destroy(gameObject);
                this.gameObject.SetActive(false);
                //OutputGameObjects[]
                destroyedObjectsText.text = (int.Parse(destroyedObjectsText.text) + 1).ToString();
                if (!isTrash)
                {
                   
                    OutputGameObjects[int.Parse(destroyedObjectsText.text) - 1].SetActive(true);
                }
                
            }
            // indeks toplama e?itse sil objeyi
            
        }
        else if (!isContinue && Vector3.Distance(this.transform.position, nextPoses[i].position) > 1)
        {
            isContinue = true;
        }

        else
        {

        }
    }
}
