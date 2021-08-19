using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGURL_Movement : MonoBehaviour
{
    public CharacterController2D controller;

    //animation 
    public Animator animator;



    //movement
    public float runSpead = 40f;
    float horizontalMove = 0f;
    bool Jump = false;
    bool Crouch = false;
    bool IsJumpingifCrouching = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("GurlHorizontal") * runSpead;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetKeyDown(KeyCode.S))
        {
            Crouch = !Crouch;

        }

        if (Crouch == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Jump = true;
                animator.SetBool("IsJumpingifCrouching", true);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Jump = true;
            animator.SetBool("IsJumping", true);
        }
        OnCrouching(Crouch);


    }

    public void OnLanding()
    {


        if (Crouch == false)
        {
            animator.SetBool("IsJumping", false);

        }
        else if (Crouch == true)
        {
            animator.SetBool("IsJumpingifCrouching", false);

        }


    }


    public void OnCrouching(bool isCrouching)
    {

        animator.SetBool("IsCrouching", isCrouching);

    }

    private void FixedUpdate()
    {
        //when we move our charcter
        controller.Move(horizontalMove * Time.fixedDeltaTime, Crouch, Jump);
        Jump = false;


    }
}
