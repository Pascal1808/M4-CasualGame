using UnityEngine;

public class SpawnTime : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public float spawnDelay = 5f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), spawnDelay, spawnDelay);
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
