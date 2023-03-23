using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamSpawner : MonoBehaviour
{
    public GameObject iceCreamPrefab; 
    public float spawnRate = 10f; 
    public float minSpawnX = -3f; 
    public float maxSpawnX = 3f; 

    public float nextSpawnTime = 0.2f; 

    void Update()
    {
    
        if (Time.time > nextSpawnTime)
        {
            
            float spawnX = Random.Range(minSpawnX, maxSpawnX);
            Vector3 spawnPos = new Vector3(spawnX, transform.position.y, 0f);
            Instantiate(iceCreamPrefab, spawnPos, Quaternion.identity);
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
