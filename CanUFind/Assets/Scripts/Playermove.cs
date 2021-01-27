using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    private float speed = 10;

    public CharacterController playercontroller;

    private float jumpspeed = 5;

    private float g = 20;

    Vector3 move;

    // Update is called once per frame
    void Update()
    {
        float x=0, z=0;
        if (playercontroller.isGrounded)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");

            move =( transform.right * x + transform.forward * z)*speed;

            if (Input.GetAxis("Jump")==1)
            {
                move.y = jumpspeed;
            }
        }
        move.y = move.y - g * Time.deltaTime;
        
        playercontroller.Move(move*Time.deltaTime);

    }
}
