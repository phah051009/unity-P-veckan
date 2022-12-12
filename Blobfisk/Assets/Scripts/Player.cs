using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0;
    
    float vertical;

    Vector2 movement;
    Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 0;
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void PlayerInput()
    {   
        vertical = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
        rigidbody.velocity = new Vector2(0f, vertical * playerSpeed);
    }
}
