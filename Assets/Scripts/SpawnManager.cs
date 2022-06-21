using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    //set range to spawn enemy
    private float spawnRangeX = 32f;
    private float spawnRangeZ = 55f;
    //set the spawn rate
    private float spawnDelay = 2f;
    private float[] spawnInterval = new float[3]{1f,1.25f, 1.5f};
    
    // Start is called before the first frame update
    void Start()
    {   
        //spawn enemy after apecific interval
        InvokeRepeating("SpawnRandomEnemy", spawnDelay, spawnInterval[Random.Range(0,3)]);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomEnemy()
    {   
        //spawn enemy in random location in given range
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Vector3 spawnRange = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 2f, spawnRangeZ);

        Instantiate(enemyPrefab[enemyIndex], spawnRange, enemyPrefab[enemyIndex].transform.rotation);
    }
}
