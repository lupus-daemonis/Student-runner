using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 0f;
    public float forwardForce = 0f;
    public GameObject obstacle;


    private Rigidbody2D myRB;
    private bool canJump;


    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
    public void Jump()
    {

        if (canJump)
        {
            canJump = false;

            if (transform.position.x < -3)
            {
                forwardForce = 2f;
            }
            else
            {
                forwardForce = 0f;
            }

            myRB.velocity = new Vector2(forwardForce, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        canJump = true;

        if (other.gameObject.tag == "Banana" || other.gameObject.tag == "Nerd")
        {
            forwardForce = -2f;
            myRB.velocity = new Vector2(forwardForce, jumpForce);
            canJump = false;
        }
    }
}