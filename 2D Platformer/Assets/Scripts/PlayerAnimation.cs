using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator a;
    bool left;
    bool right;
    bool crouch;
    //public static bool jump;
    //float y;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        left = false;
        right = false;
        crouch = false;
        //jump = false;
        //y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //if (y < transform.position.y)
        //{
        //    jump = true;
        //    y = transform.position.y;
        //}else
        //{
        //    jump = false;
        //    y = transform.position.y;
        //    //Debug.Log("fall");
        //}

        if (PlayerController.hide == true)
        { crouch = true; }
        else { crouch = false; }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        { left = true; }
        else { left = false; }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        { right = true; }
        else { right = false; }

        if (crouch == true) { a.SetBool("Crouch", true); }
        else { a.SetBool("Crouch", false); }

        if (left == true) { a.SetBool("Left", true); }
        else { a.SetBool("Left", false); }

        if (right == true) { a.SetBool("Right", true); }
        else { a.SetBool("Right", false); }

        if (PlayerController.canJump == false) { a.SetBool("Jump", true); }
        else { a.SetBool("Jump", false); }

    }
}
