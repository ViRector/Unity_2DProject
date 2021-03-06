using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public float jumpTime;
    private float jumpTimeCounter;

    private bool stoppedJumping;
    private bool canDoubleJump;

    private Rigidbody2D myRigidbody;

    public bool grounded;

    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    //private Collider2D myCollider;//

    private Animator myAnimator;

    [SerializeField] private AudioSource JumpSFX;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        // myCollider = GetComponent<Collider2D>(); //

        myAnimator = GetComponent<Animator>();

        jumpTimeCounter = jumpTime;

        stoppedJumping = true;
    }


    // Update is called once per frame
    void Update()
    {
        // grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround); //

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) /* || Input.GetMouseButtonDown(0)*/ )
        {
            if (grounded)
            {
                JumpSFX.Play();

                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                stoppedJumping = false;
            }

            if(!grounded && canDoubleJump)
            {
                JumpSFX.Play();

                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                canDoubleJump = false;
                stoppedJumping = false;
                jumpTimeCounter = jumpTime;


            }

            myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        }
        if (Input.GetKey (KeyCode.Space) && stoppedJumping == false)
        {
            if(jumpTimeCounter > 0)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }
        if (Input.GetKeyUp (KeyCode.Space))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }
        if (grounded)
        {
            jumpTimeCounter = jumpTime;
            canDoubleJump = true;
        }
    }
}
