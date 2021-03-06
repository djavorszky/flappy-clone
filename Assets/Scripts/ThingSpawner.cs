using System.Collections.Generic;
using UnityEngine;

public class ThingSpawner : MonoBehaviour
{
    public GameObject thingToSpawn;

    public float startingXPosition = 10f;

    public float despawnXPosition = -10f;

    public float minYSpawnLocation = -2f;

    public float maxYSpawnLocation = -6f;

    [Range(.5f, 3f)]
    public float spawnInterval = 1.0f;

    private float timer;
    private readonly HashSet<GameObject> entities = new HashSet<GameObject>();

    private void Start()
    {
        timer = spawnInterval;

        entities.Add(Instantiate(thingToSpawn, SpawnPosition, Quaternion.identity));
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            entities.Add(Instantiate(thingToSpawn, SpawnPosition, Quaternion.identity));
            timer = spawnInterval;

            DespawnEntities();
        }
    }

    private void DespawnEntities()
    {
        entities.RemoveWhere(item =>
        {
            if (item.gameObject.transform.position.x <= despawnXPosition)
            {
                Destroy(item);
                return true;
            }

            return false;
        });
    }

    private Vector3 SpawnPosition => new Vector3(startingXPosition, Random.Range(minYSpawnLocation, maxYSpawnLocation));
}
