using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [Header("Spawner on/off")][SerializeField] bool canSpawn = true;
    [Header("Enemy List")]
    [SerializeField] GameObject[] Prefabs;  
    [Header("Spawn Point")][SerializeField] Transform Waypoint;
    [SerializeField] Transform Player;
    Vector2  whereToSpawn;
    [Space][SerializeField] float spawnRate = 2f;
    [Space][SerializeField] float Distance = 5f;
    float nextSpawn = 0.0f; 
    float PlayerStartY;
    void Awake()
    {
        PlayerStartY = Player.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(canSpawn)
            SpawnEnemy();
    }


    void SpawnEnemy(){
        
        if(Time.time > nextSpawn){            
            nextSpawn = Time.time + spawnRate;
            float rand = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2 (Player.position.x + Distance, PlayerStartY);
            int randEnemy = Random.Range(0,Prefabs.Length);
            if(Prefabs[randEnemy].name == "Bat")
                whereToSpawn.y = whereToSpawn.y + Random.Range(1,4);
            Instantiate(Prefabs[randEnemy], whereToSpawn, Quaternion.identity);
        }
    } 
}
