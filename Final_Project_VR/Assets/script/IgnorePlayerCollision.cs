using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayerCollision : MonoBehaviour
{
    Collider c;
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Ground") && !collision.gameObject.CompareTag("Furniture") && !collision.gameObject.CompareTag("Throwable"))
        {
            Physics.IgnoreCollision(collision.collider,c);
        }
    }
}
