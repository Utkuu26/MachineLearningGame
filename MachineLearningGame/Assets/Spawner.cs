using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public InputObjects inputObjectPrefab;
    public Transform endTransform;

    public List<InputObjects> SpawnedInputObjects = new List<InputObjects>();
    [SerializeField] private int _maxSpawnCount = 10;

    [SerializeField] private float _spawnPeriod = 2f;

    private float nextSpawnTime = 0;
    // Update is called once per frame
    void Update()
    {
        HandleNullElements();
        if (SpawnedInputObjects.Count >= _maxSpawnCount)
        {
            return;
        }

        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + _spawnPeriod;
            Spawn();
        }

    }

    private void Spawn()
    {

        var inputObject = Instantiate(inputObjectPrefab);
        inputObject.GetComponent<InputObjects>().nextPos = endTransform;
       //inputObject.transform.position = this.transform.position;
        SpawnedInputObjects.Add(inputObject);


    }

    private void HandleNullElements()
    {
        for (int i = SpawnedInputObjects.Count - 1; i >= 0; i--)
        {
            if (SpawnedInputObjects[i] == null)
            {
                SpawnedInputObjects.RemoveAt(i);
            }
        }

    }
}
