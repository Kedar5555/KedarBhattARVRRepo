using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject grabbablePrefab; // The grabbable object prefab
    public int numberOfObjects = 10;   // Number of objects to spawn
    public Vector3 spawnArea = new Vector3(604f, 0, 388.9f); // Define the area for spawning

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (float i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
                spawnArea.y,
                Random.Range(-spawnArea.z / 2, spawnArea.z / 2)
            );
            Instantiate(grabbablePrefab, randomPosition, Quaternion.identity);
        }
    }
}
