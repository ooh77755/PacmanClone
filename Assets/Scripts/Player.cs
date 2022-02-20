using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5f;

    Vector2 direction; 
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move();
        CheckInput();
        FlipSprite();
    }

    private void Move()
    {
        float playerInputHorizontal = Input.GetAxis("Horizontal");
        float playerInputVertical = Input.GetAxis("Vertical");
        Vector2 pacmanVelocity = new Vector2(playerInputHorizontal * moveSpeed, playerInputVertical * moveSpeed);
        rb.velocity = pacmanVelocity;
    }

    private void CheckInput()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }

        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
    }

    private void FlipSprite()
    {
        if(direction == Vector2.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0f);
        }

        else if(direction == Vector2.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0f);
        }

        else if(direction == Vector2.up)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 90f);
        }

        else if(direction == Vector2.down)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, -90f);
        }
    }
}
