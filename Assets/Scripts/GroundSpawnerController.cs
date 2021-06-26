using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GroundSpawnerController : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject[] terrains;
    int randomTerrain;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnTerrain", 0f, 1f);
    }

    void SpawnTerrain()
    {
        if (spawnAllowed)
        {
            randomTerrain = UnityEngine.Random.Range(0, terrains.Length);
            Instantiate(terrains[randomTerrain], spawnPoint.position, Quaternion.identity);

        }
    }

   
}
