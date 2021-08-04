using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpead = 40f;
    float horizontalMove = 0f;
    bool Jump = false;

    // Update is called once per frame
    void Update()
    {
      horizontalMove = Input.GetAxisRaw("Horizontal") * runSpead;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump = true;
        }


    }


    private void FixedUpdate()
    {
        //Where we move our charcter
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, Jump);
        Jump = false;
    }

}

