using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5f;
    int health = 200;

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
        WrapAround();
    }

    private void WrapAround()
    {
        if(transform.position.x > 1.5f)
        {
            transform.position = new Vector2(-17f, -1.5f);
        }

        else if(transform.position.x < -17f)
        {
            transform.position = new Vector2(1f, -1.5f);
        }
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.gameObject.GetComponent<DamageDealer>();
        if(!damageDealer)
        {
            return;
        }
        ProcessHit(damageDealer);
    }

    private void ProcessHit(DamageDealer damageDealer)
    {
        health -= damageDealer.GetDamage();

        if(health <=0)
        {
            Destroy(gameObject);
        }
    }
}
