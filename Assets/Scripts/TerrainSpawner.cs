using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{

    public Camera MainCamera;


    // Update is called once per frame
    void FixedUpdate()
    {     
        transform.position = new Vector3(MainCamera.transform.position.x + MainCamera.pixelWidth / 47, -4.3f, transform.position.z);
    }
}
