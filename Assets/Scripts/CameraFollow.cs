using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    public Transform chick;
    public float cameraDistance = 30.0f;
    // Start is called before the first frame update
    void Awake()
    {
      //GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(chick.position.x, 0, transform.position.z);
    }
}
