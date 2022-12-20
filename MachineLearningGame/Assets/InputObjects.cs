using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputObjects : MonoBehaviour
{
    public float speed;
    public Transform nextPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveImg(nextPos);
    }

    public void MoveImg(Transform nextPos)
    {
        if (this.transform.position != nextPos.position)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, nextPos.position, speed * Time.deltaTime);
        }

        if (this.transform.position == nextPos.position)
        {
            this.enabled = false;
        }
    }
}
