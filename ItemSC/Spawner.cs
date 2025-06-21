using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public float spawnInterval = 5f;
    public Transform[] spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnItem();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnItem()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(itemPrefab, spawnPoints[index].position, Quaternion.identity);
    }
}
