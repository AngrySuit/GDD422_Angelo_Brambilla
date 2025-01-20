using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEnemyMove : MonoBehaviour
{

    [SerializeField] BoxCollider2D wallCheck;
    [SerializeField] Rigidbody2D rb; 

    [SerializeField] int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Move();
       
    }

    // Changes the direction the enemy looks and moves when hitting a wall
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            speed *= -1;
            transform.localScale *= -1; 
        }
    }

    // moves the enemy 
    private void Move()
    {
        rb.velocity = new Vector2 (0,speed);
    }
}
