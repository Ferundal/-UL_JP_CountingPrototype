using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGeneratorScript : MonoBehaviour
{
    [SerializeField] private GameObject[] trashPrefabs;
    [SerializeField] private Vector3 trashOffsetPosition = new Vector3(0, -1.0f, 0);
    [SerializeField] private float minSpawnTime = 1;
    [SerializeField] private float maxSpawnTime = 2;
    private Vector3 spawnPosition;
    private int spawnAmount;
    // Start is called before the first frame update
    void Awake()
    {
        spawnAmount = 0;
        spawnPosition = this.transform.position + trashOffsetPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSpawn(int spawnAmount)
    {
        this.spawnAmount += spawnAmount;
        StartCoroutine(SpawnCycle());
    }

    public void StopSpawn()
    {
        this.spawnAmount = 0;
    }
    IEnumerator SpawnCycle()
    {
        while (this.spawnAmount > 0)
        {
            Debug.Log("Shoud Spawn " + this.spawnAmount);
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            SpawnRandomTrash();
            --(this.spawnAmount);
            Debug.Log("Shoud Spawn " + this.spawnAmount);
        }
    }
    private void SpawnRandomTrash()
    {
        int currentTrashPrefab = Random.Range(0, trashPrefabs.Length);
        Instantiate(trashPrefabs[currentTrashPrefab], spawnPosition, Random.rotation);
    }
}
