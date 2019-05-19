using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed,jump;
    Rigidbody2D rb;
    bool j;
    public static int collected;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        j = false;
        collected = 0;
    }

    void Update()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal") * speed;
        //float ySpeed = Input.GetAxisRaw("Vertical") * speed;

        xSpeed *= Time.deltaTime;
        //ySpeed *= Time.deltaTime;
        transform.Translate(xSpeed, 0,0);

        if (Input.GetButtonDown("Jump") && j == true)
        {
            rb.velocity = new Vector2(0f, jump);
        }
        Debug.Log(j);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            j = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            j = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collected++;
        }
    }
}
