using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    private float spawnRate;

    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate)
        {
            timeAfterSpawn = 0f;
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
