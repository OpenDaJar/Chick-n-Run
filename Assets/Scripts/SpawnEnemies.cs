using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject[] enemies;
    int randomEnemy;
    bool spawnAllowed;
    public float height;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        randomEnemy = UnityEngine.Random.Range(0, enemies.Length);
        GameObject new_enemy = Instantiate(enemies[randomEnemy]);
        new_enemy.transform.position = new Vector3(MainCamera.transform.position.x + MainCamera.pixelWidth / 47, -2.3f, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            randomEnemy = UnityEngine.Random.Range(0, enemies.Length);
            GameObject new_enemy = Instantiate(enemies[randomEnemy]);
            new_enemy.transform.position = new Vector3(MainCamera.transform.position.x + MainCamera.pixelWidth / 47, -2.3f, transform.position.z);
            Destroy(new_enemy, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
