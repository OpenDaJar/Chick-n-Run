using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Speed")]
    [Range(0f,10f)][SerializeField] float speed = 2.00f;
    [Range(.001f,1f)][SerializeField] float speedMultiplier = 0.001f;
    [Range(8f,15f)][SerializeField] float maxSpeed = 10f;
    [Header("Jumping")]
    [Space][SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;
    [Range(3f,10f)][SerializeField] float jumpspeed = 6.0f;
    bool isTouchingGround;
    [Header("Transform")]
    [SerializeField] Transform groundCheck;
    [SerializeField] Transform CurrentPosition;
    [Header("Animator")]
    [SerializeField] Animator animator;
    Rigidbody2D rb;
    [Header("Can player Die?")][SerializeField] bool Immortal;
    [SerializeField] GameObject GameLevelController;
    private bool jump = false;
    private bool canJump;
    bool alive;
    void Awake(){
        Debug.Log("Player Created.");
        rb = GetComponent<Rigidbody2D>();
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if ((Input.GetButtonDown("Jump") || Input.touchCount == 1) && isTouchingGround && canJump){
            jump = true;
        }
    }

    //FixedUpdate is called X times a second
    void FixedUpdate(){
        //MOVE
        if (speed > maxSpeed){
            speed = maxSpeed;
        }else{
            Invoke("Accelerate",1.0f);
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);
        //JUMP
        if(jump){
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            jump = false;
            canJump = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        Debug.Log("Hit trigger ??");
        Death();
    }
    
    void OnCollisionEnter2D(Collision2D smthg){
        canJump = true;
    }

    //method to auto increase speed with at a steady rate
    void Accelerate(){
        float newSpeed = speed + speed*speedMultiplier;
        if (newSpeed > maxSpeed)
            newSpeed = maxSpeed;
        speed =  newSpeed;
    }

    void Death(){
        if(!this.Immortal){
            Debug.Log("Player died");
            alive = false;
            GameLevelController.gameObject.SendMessage("PlayerDied");
            speed = 0;
            animator.SetTrigger("Death");
        }  
    }

    public void ChangeScene(){
        SceneManager.LoadScene("GameOver");
    }
}
