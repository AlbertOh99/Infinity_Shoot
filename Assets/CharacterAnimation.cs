using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator anim;
    private CharacterController controller;
        private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        bool isWalking = controller.velocity.normalized.magnitude == 1;
        bool isGrounded = controller.isGrounded;


        anim.SetBool("Walking", isWalking && isGrounded);

        anim.SetBool("Jump", !isGrounded);
        


    }

}
