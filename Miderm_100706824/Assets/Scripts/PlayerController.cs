using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public GameObject CurrentCheckpoint;
    public GameObject StartCheckpoint;

    private Vector3 pVelocity;

    private bool pGrounded;
    private bool Dead = false;
    private bool Restart = false;

    private float pSpeed = 7.6f;
    private float pTurnSpeed = 110.0f;
    

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
            if (pGrounded)
            {
                pVelocity.y = 0f;
            }
            else
            {
                pVelocity.y += gravity * Time.deltaTime;
            }

            
            controller.Move(pVelocity * Time.deltaTime);
        }

        if (Dead) //If you die get back to your previous checkpoint.
        {
            transform.position = CurrentCheckpoint.transform.position;
            Dead = false;
        }

        if (Restart)
        {
            transform.position = StartCheckpoint.transform.position;
            Restart = false;
        }
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Kill-Box")
        {
            Dead = true;
           // print(Dead);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Kill-Box") //Kill triggers
        {
            Dead = true;
          //  print(Dead);
        }

        if (other.gameObject.tag == "Checkpoint") //Checkpoint!
        {
            CurrentCheckpoint = other.gameObject;
            Debug.Log("Checkpoint_Got!");
            other.gameObject.tag = "CP_Active";
        }

        if(other.gameObject.tag == "Finish")
        {
            Dead = false;
            Restart = true;
            CurrentCheckpoint = StartCheckpoint;
        }
    }

}
