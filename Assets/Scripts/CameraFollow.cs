using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    [Header("Player")]
    public Transform Player;
    [Space]
    [Header("Camera Offset")]
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Player.position.x + offset.x, 0 + offset.y, transform.position.z);
    }
}
