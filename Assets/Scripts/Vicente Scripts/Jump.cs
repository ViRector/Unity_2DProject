using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Transform Player;
    public float speed;
    public float fallspeed;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * speed;

            //if(Input.GetButton("Fire1"))
            //{
            //    Levitar();
            //}
        }

    }

    private void Levitar()
    {
        rb.gravityScale = 0.1f;
        rb.velocity = Vector2.down * fallspeed;
    }
}
