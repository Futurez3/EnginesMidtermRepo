using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    private Vector3 pVelocity;

    private bool pGrounded;

    private float pSpeed = 7.8f;
    private float pTurnSpeed = 60.0f;
    

    private float gravity = -9.81f;


    void Update()
    {
        pGrounded = controller.isGrounded;
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        //Turning
        transform.Rotate(0, Horizontal * pTurnSpeed * Time.deltaTime, 0);
        //Forward Movement
        Vector3 move = transform.forward * Vertical * pSpeed;

        controller.Move(move * Time.deltaTime);

       
       // Debug.Log(transform.rotation.y);


        if (pGrounded && pVelocity.y < 0)
        {
            pVelocity.y = 0f;
        }

        pVelocity.y += gravity * Time.deltaTime;
        controller.Move(pVelocity * Time.deltaTime);
    }
}
