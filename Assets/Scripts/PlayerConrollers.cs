using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class PlayerConrollers : MonoBehaviour
{
    public float maxSpeed = 10f;
    public float speed = 5f;
    private float movement = 0f;
    public float jumpspeed = 8f;
    private Rigidbody2D rigibody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    bool isTouchingGround;
    private Animator playerAnimation;



    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        

       
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            rigibody.velocity = new Vector2(rigibody.velocity.x, jumpspeed);
          }

        playerAnimation.SetFloat("Speed", rigibody.velocity.x);
        playerAnimation.SetBool("OnGround", isTouchingGround);


        float move = 1.0f;

        playerAnimation.SetFloat("Speed", Mathf.Abs(move));

        rigibody.velocity = new Vector2(move * maxSpeed, rigibody.velocity.y);



    }
}
