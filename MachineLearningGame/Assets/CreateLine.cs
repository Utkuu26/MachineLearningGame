using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        line.positionCount = 2;
        CreateLines(redConn1, redConn2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateLines(Transform startTransform, Transform endTrasnform)
    {
        line.SetPosition(0, startTransform.position + new Vector3(0,0,-3f));
        line.SetPosition(1, endTrasnform.position + new Vector3(0, 0, -3f));
        

    }
}
