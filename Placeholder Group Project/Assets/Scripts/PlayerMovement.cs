using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variables
    public float movementForce = 10f;
    public float jumpForce = 1000f;
    public int jumpCharge = 1;
    public Collider2D jumpSensor;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the Rigidbody component off our player so we can use it.
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Find out from the rigidbody what our current horizontal and vertical speeds are.
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // Get the animator component that will be used for our animation.
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are.
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);


        // Condition: When a player presses the D key...
        if (Input.GetKey(KeyCode.D) == true)
        {
            // Action: Apply a force (move the player)
            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.right * movementForce);

        }

        // Condition: When a player presses the A key...
        if (Input.GetKey(KeyCode.A) == true)
        {
            // Action: Apply a force (move the player)
            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.left * movementForce);

        }

        if (jumpSensor.IsTouchingLayers(LayerMask.GetMask("Ground")))
            jumpCharge = 1;
 
        //Condition: When the player first presses space bar
        if (Input.GetKeyDown(KeyCode.Space) == true && jumpCharge > 0)
        {
            //Action: Apply a force (push the player up)
            // Add a force to the Rigidbody to move our player
            ourRigidbody.AddForce(Vector2.up * jumpForce);
            jumpCharge -= 1;
        }
    }
}