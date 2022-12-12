using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.Profiling;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float enemySpeed;
    public float health { get; private set; }

    public int hitPoints { get; private set; }
    public int killPoints { get; private set; }

    Vector2 movement;
    Rigidbody2D rigidbody;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        transform.position += transform.up * enemySpeed * Time.deltaTime;
    }

}
