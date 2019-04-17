using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 2;
    public int dir = 1;

    public LayerMask ground;
    public LayerMask playerLayer;

    public Transform leftFoot;
    public Transform rightFoot;
    private Transform player;

    private bool playerIsClose;

    public bool leftEdge;
    public bool rightEdge;

    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sr = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {

        leftEdge = !Physics2D.OverlapCircle(leftFoot.position, 0.5f, ground);
        rightEdge = !Physics2D.OverlapCircle(rightFoot.position, 0.5f, ground);
        if (PlayerController.crouch == true)
        {
            playerIsClose = false;
        }
        else
        {
            playerIsClose = Physics2D.OverlapCircle(transform.position, 4f, playerLayer);
        }
        if (playerIsClose)
        {
            if (player.position.x - transform.position.x > 0 && !rightEdge)
            {
                dir = 1;
                sr.flipX = false;
            }
            else if (player.position.x - transform.position.x < 0 && !leftEdge)
            {
                dir = -1;
                sr.flipX = true;
            }
            else {
                dir = 0;
            }
        }

        else {
            if (leftEdge) {
                dir = 1;
                sr.flipX = false;
            }

            if (rightEdge) {
                dir = -1;
                sr.flipX = true;
            }
        }

        rb.velocity = new Vector2(dir * speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&&PlayerController.hide==false)
        {
            DataHolder.level = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("Lose_Capture");
            Debug.Log("lose");
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Physics2D.IgnoreCollision(collision.collider,GetComponent<Collider2D>());
        }
        if (collision.gameObject.CompareTag("ground"))
        {
            if (collision.gameObject.transform.position.y > rightFoot.position.y)
            {
                if(collision.gameObject.transform.position.x > rightFoot.position.x)
                {
                    sr.flipX = true;
                    dir = -1;
                }else if (collision.gameObject.transform.position.x < leftFoot.position.x)
                {
                    sr.flipX = false;
                    dir = 1;
                }
            }
        }
    }
}
