using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -39.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    float x;
    float z;

    Vector3 velocity;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        CheckJump();
        CheckForGround();
    }

    public void CheckMovement()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        if (x != 0 || z != 0)
        {

            Vector3 move = transform.right * x + transform.forward * z;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 25f;
            }
            else
            {
                speed = 10f;
            }

            controller.Move(move * speed * Time.deltaTime);
        }
    }


    public void CheckJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    public void CheckForGround()
    {
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

}
