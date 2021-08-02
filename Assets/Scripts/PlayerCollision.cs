using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{



    
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Player"){
            // this rigidbody hit the player
            Debug.Log("Hit");
            col.gameObject.SendMessage("Death");
        }
        Debug.Log("Hit ??");
    }    
}
