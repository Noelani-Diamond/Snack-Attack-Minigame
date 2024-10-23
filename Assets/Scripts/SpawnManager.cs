using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private float startDelay = 3;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFood", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFood()
    {
        int snackIndex = Random.Range(0, foodPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-8, 8),10 ,Random.Range(-10, 10));

        Instantiate(foodPrefabs[snackIndex], spawnPos, foodPrefabs[snackIndex].transform.rotation);
       
    }


}
