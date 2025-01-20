using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject Pellet;


    [SerializeField] Vector2 move;

    [SerializeField] int score = 0;
    [SerializeField] int combo = 0;
    [SerializeField] float Ctimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Timer();

    }

    private void Timer()
    {
        // Ticks down the combo timer //
        if (Ctimer >= 1)
        {
            Ctimer -= 1 * Time.deltaTime;
        }
        // When it runs out combo resets //
        else
        {
            combo = 0;
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        // Checks if the player colided with a peelet //
        if (collision.gameObject.layer == 8)
        {
            // Increses combo Ctimer and score plus destroys the pellet colided //
            combo += 1;
            Ctimer += 5;
            Ctimer = Mathf.Clamp(Ctimer, 0, 10);
            score += 100 * combo;
            Destroy(collision.gameObject, 0.1f);
        }
    }

    void Move()
    {
        // Gets the player input and changes the velocity of the character to it//
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = move * 5;
    }
}
