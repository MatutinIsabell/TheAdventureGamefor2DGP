using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    //animation 
    public Animator animator;
    
    
    //movement
    public float runSpead = 40f;
    float horizontalMove = 0f;
    bool Jump = false;
    bool Crouch = false;

    // Update is called once per frame
    void Update()
    {
      horizontalMove = Input.GetAxisRaw("Horizontal") * runSpead;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        //if (Input.GetButtonDown("Jump"))
       if (Input.GetKey(KeyCode.Space))
        // if (Input.GetKeyDown(KeyCode.Space))
        {
          Jump = true;
          animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        //if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Crouch = true;
        } else if  (Input.GetButtonUp("Crouch"))  //(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching ( bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        //Where we move our charcter
        controller.Move(horizontalMove * Time.fixedDeltaTime, Crouch, Jump);
        Jump = false;


    }

}

