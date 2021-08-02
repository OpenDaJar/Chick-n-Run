using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWaypoin : MonoBehaviour
{
    [SerializeField] Camera MainCamera;
    [SerializeField] Transform StartPoint;
    [SerializeField] Transform EndPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartPoint.position = new Vector3(MainCamera.transform.position.x - 2,-2.16f,0);
        EndPoint.position = new Vector3(MainCamera.transform.position.x + 3,-2.16f,0);
    }
}
