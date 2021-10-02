using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingSpawner : MonoBehaviour
{

    public GameObject thingToSpawn;

    public float startingXPosition;

    [Range(.5f, 3f)]
    public float spawnInterval = 1.0f;

    private float timer;

    private void Start()
    {
        timer = spawnInterval;
        Instantiate(thingToSpawn, new Vector3(startingXPosition, -4), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(thingToSpawn, new Vector3(startingXPosition, -4), Quaternion.identity);
            timer = spawnInterval;
        }
    }
}
