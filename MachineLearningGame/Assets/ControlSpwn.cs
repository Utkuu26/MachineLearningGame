using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpwn : MonoBehaviour
{
    public List<Spawner> spawners;
    void Start()
    {
        Component[] spawners;
        spawners = GetComponents(typeof(Spawner));

       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("isStart")==1)
        {
            foreach (Spawner spwn in spawners)
                spwn.enabled = true;
            PlayerPrefs.SetInt("isStart", 0);
        }
    }
}
