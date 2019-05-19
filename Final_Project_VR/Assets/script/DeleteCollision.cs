using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCollision : MonoBehaviour
{
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //controller.detectCollisions = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Throwable")||collision.gameObject.CompareTag("Furniture"))
        {
            Physics.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider>());
        }
    }
}
