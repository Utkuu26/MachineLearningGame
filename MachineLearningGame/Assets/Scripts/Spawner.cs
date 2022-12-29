using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public InputObjects inputObjectPrefab;
    public Transform endTransform;
    public Transform endTransform1;
    public Transform endTransform2;
    public TextMeshProUGUI spawnedObjectsText;
    public TextMeshProUGUI destroyedObjectsText1;
    public bool isBlue;
    public bool isRed;
    public bool isGreen;
    public bool hasDelay;
    public bool hasDelay2;
    public AudioSource _asSpawn;


    public List<InputObjects> SpawnedInputObjects = new List<InputObjects>();
    [SerializeField] private int _maxSpawnCount = 10;

    [SerializeField] private float _spawnPeriod = 2f;

    public float nextSpawnTime = 0;
    // Update is called once per frame

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        if (isBlue)
        {
            hasDelay = true;
        }
        yield return new WaitForSeconds(1f);
        if (isGreen)
        {
            hasDelay2 = true;
        }

    }
    void Update()
    {
        if (hasDelay && isBlue)
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

        if(isRed)
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

        if (hasDelay2 && isGreen)
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
        

    }

    private void Spawn()
    {
        _asSpawn.Play();
        var inputObject = Instantiate(inputObjectPrefab , this.transform);
        inputObject.transform.position = this.transform.GetChild(1).transform.position;
        inputObject.GetComponent<InputObjects>().nextPoses[0] = endTransform;
        inputObject.GetComponent<InputObjects>().nextPoses[1] = endTransform1;
        inputObject.GetComponent<InputObjects>().nextPoses[2] = endTransform2;
        inputObject.GetComponent<InputObjects>().destroyedObjectsText=destroyedObjectsText1;

       //inputObject.transform.position = this.transform.position;
        SpawnedInputObjects.Add(inputObject);
        spawnedObjectsText.text = (10 - SpawnedInputObjects.Count).ToString();


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
