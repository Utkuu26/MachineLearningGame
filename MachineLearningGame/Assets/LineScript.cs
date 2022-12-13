using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(LineRenderer))]

public class LineScript : MonoBehaviour
{
    private LineRenderer lr;
    private Rigidbody rb;
    public float timeForNextRay;
    public List<GameObject> WayPoints;
    private float timer=0;
    private int currentWayPoint=0;
    private int wayIndex;
    private bool move;
    private bool touchStartedOnButton;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lr = GetComponent<LineRenderer>();
       
        lr.enabled = false;
        wayIndex = 1;
        move = false;
        touchStartedOnButton = false;
    }

    public void OnMouseDown()
    {
        lr.enabled = true;
        touchStartedOnButton = true;
        lr.positionCount = 1;
        lr.SetPosition(0, transform.position);
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0) && timer > timeForNextRay && touchStartedOnButton)
        {
            Vector3 worldFromMousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100));
            Vector3 direction = worldFromMousePos - Camera.main.transform.position;
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, direction, out hit , 100f))
            {
                Debug.DrawLine(Camera.main.transform.position, direction, Color.red, 1f);
                GameObject newWayPoint = new GameObject("WayPoint");
                newWayPoint.transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                WayPoints.Add(newWayPoint);
                lr.positionCount = wayIndex + 1;
                lr.SetPosition(wayIndex, newWayPoint.transform.position);
                timer = 0;
                wayIndex++;
            }
        }



    }
}
