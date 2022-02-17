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
        float playerInput = Input.GetAxis("Horizontal");
        Vector2 pacmanVelocity = new Vector2(playerInput * moveSpeed, rb.velocity.y);
        rb.velocity = pacmanVelocity;
    }
}
