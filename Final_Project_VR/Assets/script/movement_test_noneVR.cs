using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_test_noneVR : MonoBehaviour
{
    public float speed;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal") * speed;
        float zSpeed = Input.GetAxisRaw("Vertical") * speed;

        //rb.velocity = new Vector3(xSpeed, rb.velocity.y, zSpeed);
        xSpeed *= Time.deltaTime;
        zSpeed *= Time.deltaTime;
        transform.Translate(xSpeed, 0, zSpeed);
        //if (Input.GetKeyDown("escape"))
        //{
           // Cursor.lockState = CursorLockMode.None;
       // }
    }
}

