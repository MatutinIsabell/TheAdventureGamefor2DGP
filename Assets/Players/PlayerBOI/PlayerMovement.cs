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
    bool IsJumpingifCrouching = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpead;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));




        if (Crouch == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Jump = true;
                animator.SetBool("IsJumpingifCrouching", true);
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
            {
                Jump = true;
                animator.SetBool("IsJumping", true);
            }
        
       
        if (Input.GetKeyDown(KeyCode.DownArrow))                  
        {
            Crouch = !Crouch;
                      

        } 
        
    }

    public void OnLanding()
    {
        

       if(Crouch == false)
        {
            animator.SetBool("IsJumping", false);
            
        }
        else if (Crouch == true)
        {
            animator.SetBool("IsJumpingifCrouching", false);
            
        }
    
    
    }


    public void OnCrouching ( bool isCrouching)
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

