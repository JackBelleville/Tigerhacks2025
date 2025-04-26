using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    private Rigidbody rb; //holds reference to rigidbody of object
    private float movementX;
    private float movementY;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>(); //gets vector2, a 2d vector data from movement value
        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    //this function is called when player game object first touches a trigger collider, and other is the other collider
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false); //.SetActive function disables object
        }

        count++;
    }
}
