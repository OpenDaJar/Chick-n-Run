using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerainGenerator : MonoBehaviour
{
    [Header("Ground Prefabs")]
    [SerializeField] Transform[] Prefabs;
    [SerializeField] GameObject Ground_01;    
    float GroundWidth;
    [Space][Header("Spawn Points")] 
    [SerializeField] Transform Waypoint;
    int prev = 0;

    void Awake(){
        GroundWidth = Ground_01.GetComponentInChildren<BoxCollider2D>().size.x;
        Waypoint.position.Set(0,Waypoint.position.y,Waypoint.position.z);
        
    }

    void FixedUpdate(){
        //not like this coz it spams
        SpawnTerrain();
    }
    void SpawnTerrain(){
        if(transform.position.x < Waypoint.position.x){
            int rand = Random.Range(0, Prefabs.Length-2);
            if(prev == Prefabs.Length -1 || prev == Prefabs.Length)
                rand = Random.Range(0, Prefabs.Length-2);
            prev = rand;
            transform.position = new Vector3(transform.position.x + GroundWidth/2, transform.position.y, transform.position.z);
            Instantiate(Prefabs[rand], transform.position, transform.rotation);
        }
    }
}
