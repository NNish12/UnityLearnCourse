using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX = 20f;
    [SerializeField] private float spawnPosZ = 20f;
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    private void Update()
    {

    }
    private void SpawnRandomAnimal()
    {
        int index = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[index], spawnPos, animalPrefabs[index].transform.rotation);
    }
}
