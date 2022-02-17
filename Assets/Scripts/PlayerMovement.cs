using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float moveSpeed = 5f;

    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float playerInputHorizontal = Input.GetAxis("Horizontal");
        float playerInputVertical = Input.GetAxis("Vertical");
        Vector2 pacmanVelocity = new Vector2(playerInputHorizontal * moveSpeed, playerInputVertical * moveSpeed);
        rb.velocity = pacmanVelocity;
    }
}
