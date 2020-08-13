using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject enemy;
    public float height;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(enemy);
        newpipe.transform.position = transform.position + new Vector3(0, height, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(enemy);
            newpipe.transform.position = new Vector3(MainCamera.transform.position.x + MainCamera.pixelWidth / 47, -2.3f, transform.position.z);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
