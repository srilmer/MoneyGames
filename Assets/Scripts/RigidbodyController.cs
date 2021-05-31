using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    private bool canMove = true;

    public bool CanMove 
    { 
        set 
        { 
            canMove = value;
            if (canMove == false)
                rb.velocity = Vector3.zero;
        } 
    }

    public void Move(Vector3 movement)
    {
        if (canMove)
        {
            movement.Normalize();
            rb.velocity = movement * speed;
        }     
    }

    public Vector3 GetPosition()
    {
        return rb.position;
    }

    //// Alternative way of moving the RigidBody
    //void FixedUpdate()
    //{
       
    //    Vector3 newPosition = rb.position + (movement * speed * Time.deltaTime);
    //    rb.MovePosition(newPosition);
    //}
}
