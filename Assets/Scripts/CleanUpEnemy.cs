using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanUpEnemy : MonoBehaviour
{

    void FixedUpdate(){
        OnBecameInvisible();
        //if(this.transform.position.y < -1.24 )
        //    Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D col){
        Destroy(gameObject);
    }

    void OnBecameInvisible() {
        Debug.Log("Destroyed");
        Destroy(gameObject,10);
    }
}
