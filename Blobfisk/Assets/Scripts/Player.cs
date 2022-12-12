using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0;

    Vector2 movement;
    Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
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
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector2(0f, vertical);
    }

    private void MovePlayer()
    {
        rigidbody.velocity = new Vector2(movement * playerSpeed, rigidbody.velocity.y);
    }
}
