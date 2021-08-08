using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUp : MonoBehaviour
{

    void Awake(){
        Debug.Log("Awoke");
    }

    void FixedUpdate(){
        OnBecameInvisible();
    }
    void OnBecameInvisible() {
        Debug.Log("Destroyed");
        Destroy(gameObject,10);
    }
}
