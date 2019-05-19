using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryMove : MonoBehaviour
{
    // Vector3 pos;
    Rigidbody rb;
    public float speed;
   // public GameObject eye;
    Vector2 rotation = Vector2.zero;
    float y;
   // Vector3 cr;
    // Start is called before the first frame update
    void Start()
    {
        // pos = transform.position;
        rb = GetComponent<Rigidbody>();
        //cr = eye.transform.eulerAngles;
        //transform.eulerAngles = new Vector;
        y = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 primaryAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        //rotation = new Vector2(cr.x, cr.y);
        //pos += new Vector3(primaryAxis.x * speed, 0, primaryAxis.y * speed);
        //transform.position = pos;

        transform.position = new Vector3(transform.position.x, y, transform.position.z);

        transform.eulerAngles = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.CenterEye).eulerAngles;
        float x = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x * speed;
        float z = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y * speed;

        x *= Time.deltaTime;
        z *= Time.deltaTime;
        transform.Translate(x, 0, z);
        
    }
}
