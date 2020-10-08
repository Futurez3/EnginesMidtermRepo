using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public GameObject CurrentCheckpoint;

    private Vector3 pVelocity;

    private bool pGrounded;
    private bool Dead = false;

    private float pSpeed = 7.8f;
    private float pTurnSpeed = 75.0f;
    

    private float gravity = -9.81f;

    //void Start()
    //{
    //    Debug.Log(controller.GetComponent<Collider>().isTrigger);
    //}

    void Update()
    {
        pGrounded = controller.isGrounded;
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        //Turning
        transform.Rotate(0, Horizontal * pTurnSpeed * Time.deltaTime, 0);
        //Forward Movement
        Vector3 move = transform.forward * Vertical * pSpeed;

        if (!Dead)
        {
            controller.Move(move * Time.deltaTime);


            // Debug.Log(transform.rotation.y);

            //Gravity is fun
            if (pGrounded && pVelocity.y < 0)
            {
                pVelocity.y = 0f;
            }

            pVelocity.y += gravity * Time.deltaTime;
            controller.Move(pVelocity * Time.deltaTime);
        }

        if (Dead) //If you die get back to your previous checkpoint.
        {
            transform.position = CurrentCheckpoint.transform.position;
            Dead = false;
        }
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Kill-Box")
        {
            Dead = true;
            print(Dead);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");

        if (other.gameObject.tag == "Kill-Box") //Kill triggers
        {
            Dead = true;
            print(Dead);
        }
    }

}
