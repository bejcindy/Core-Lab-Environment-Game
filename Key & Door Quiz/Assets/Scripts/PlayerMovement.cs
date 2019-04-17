using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    //public GameObject win;

    bool k;

    void Start()
    {
        k = false;
        //win.SetActive(false);
    }

    void Update()
    {
        float xSpeed = Input.GetAxisRaw("Horizontal") * speed;
        float zSpeed = Input.GetAxisRaw("Vertical") * speed;

        //rb.velocity = new Vector3(xSpeed, rb.velocity.y, zSpeed);
        xSpeed *= Time.deltaTime;
        zSpeed *= Time.deltaTime;
        transform.Translate(xSpeed, 0, zSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            Destroy(other.gameObject);
            k = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("door") && k == true)
        {
            SceneManager.LoadScene("WinningScene");
            //win.SetActive(true);
        }
    }
}
