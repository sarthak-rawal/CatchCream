using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveSpwan : MonoBehaviour
{
    public GameObject iceCreamPrefab; // Reference to the ice cream prefab
    public float spawnRate = 10f; // How often to spawn ice cream in seconds
    public float minSpawnX = -3f; // Minimum X position to spawn ice cream
    public float maxSpawnX = 3f; // Maximum X position to spawn ice cream

    public float nextSpawnTime = 0.2f; // Time until next ice cream spawn

    void Update()
    {
        // Check if it's time to spawn a new ice cream
        if (Time.time > nextSpawnTime)
        {
            // Spawn a new ice cream at a random X position at the top of the screen
            float spawnX = Random.Range(minSpawnX, maxSpawnX);
            Vector3 spawnPos = new Vector3(spawnX, transform.position.y, 0f);
            Instantiate(iceCreamPrefab, spawnPos, Quaternion.identity);

            // Set the time until the next spawn
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
