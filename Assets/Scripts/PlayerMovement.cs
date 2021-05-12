using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public static PlayerMovement isntance;

    //Health of the player
    public int HP = 100;



    //all movement/control variables
    public CharacterController controller;
    public Transform groundCheck;
    public float groundDistance = .04f;
    public LayerMask groundMask;
    bool isGrounded;
    public int doubleJump = 2;
    public float speed = 12f;
    public float gravity = -9.18f;
    public float jumpHeight = 3f;

    private int constJump;

    Vector3 velocity;
    
    void Start()
    {
        constJump = doubleJump;
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(HP);
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            doubleJump = constJump;
        }

        if (Input.GetButtonDown("Jump") && doubleJump > 0)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            doubleJump -= 1;
        }
        
        /* double jump debugging
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log(doubleJump);
        }*/

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);



    }
}
