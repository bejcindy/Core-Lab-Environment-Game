using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    public int jumpForce = 500;
    Rigidbody2D rb;

    public LayerMask GroundLayer;
    public Transform Feet;
    public static bool canJump;
    public static bool crouch;
    public static bool hide;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        crouch = false;
        hide = false;
        crouch = false;
    }

    void Update()
    {
        canJump = Physics2D.OverlapCircle(Feet.position, .4f, GroundLayer);
        //Debug.Log(crouch);

        //if (canJump == true)
        //{
        //    PlayerAnimation.jump = false;
        //    PlayerAnimation.fall = false;
        //}
    }

    void FixedUpdate()
    {
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);

        if (hide == false)
        {
            GetComponent<Collider2D>().enabled = true;
        }

        if (Input.GetKey(KeyCode.LeftShift) && canJump==true || Input.GetKey(KeyCode.RightShift) && canJump==true)
        {
            crouch = true;
        }
        else
        {
            crouch = false;
        }
        if (crouch == false)
        {
            hide = false;
        }
        if (hide == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        if (hide == true)
    //        {
    //            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
    //        }
    //        else
    //        {
    //            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(),false);
    //            DataHolder.level = SceneManager.GetActiveScene().name;
    //            SceneManager.LoadScene("Lose_Capture");
    //            Debug.Log("lose");
    //        }
    //    }
    //}
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            if (hide == true)
            {
                //Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
                GetComponent<Collider2D>().enabled = false;
            }
            else
            {
                //Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), false);
                GetComponent<Collider2D>().enabled = true;
                DataHolder.level = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene("Lose_Capture");
                Debug.Log("lose");
            }
        }
        else
        {
            GetComponent<Collider2D>().enabled = true;
            //Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), false);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("crate");
        if (collision.gameObject.CompareTag("Crate") && crouch == true)
        {
            hide = true;
        }
        else
        {
            hide = false;
        }
    }
}
