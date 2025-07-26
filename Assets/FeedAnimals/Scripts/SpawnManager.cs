
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX = 20f;
    [SerializeField] private float minSpawnRangeZ = 0f;
    [SerializeField] private float maxSpawnRangeZ = 12f;
    [SerializeField] private float spawnPosZ = 20f;
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;
    private Vector3 spawnPos;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    private void SpawnRandomAnimal()
    {
        int randomSide = Random.Range(0, 3);
        int index = Random.Range(0, animalPrefabs.Length);
        switch (randomSide)
        {
            case 0:
                spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(minSpawnRangeZ, maxSpawnRangeZ));
                Instantiate(animalPrefabs[index], spawnPos, Quaternion.Euler(0, 90, 0));
                break;
            case 1:
                spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                Instantiate(animalPrefabs[index], spawnPos, animalPrefabs[index].transform.rotation);
                break;
            case 2:
                spawnPos = new Vector3(spawnRangeX, 0, Random.Range(minSpawnRangeZ, maxSpawnRangeZ));
                Instantiate(animalPrefabs[index], spawnPos, Quaternion.Euler(0, 270, 0));
                break;
        }
        float randomZ = Random.Range(-spawnPosZ, spawnPosZ);
        Vector3 vertPos = new Vector3(spawnRangeX, 0, randomZ);
    }
}

