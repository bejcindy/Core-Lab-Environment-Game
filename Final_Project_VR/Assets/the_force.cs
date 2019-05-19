using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class the_force : MonoBehaviour
{
    public Camera camera;
    public GameObject leftHand;
    public GameObject rightHand;
    bool l, r;
    void Start()
    {

        l = false;
        r = false;
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(camera.transform.position, transform.forward);
        bool LI = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);
        bool RI = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        bool LH = OVRInput.Get(OVRInput.RawButton.LHandTrigger);
        bool RH = OVRInput.Get(OVRInput.RawButton.RHandTrigger);
        bool B = OVRInput.Get(OVRInput.Button.Two);
        bool Y = OVRInput.Get(OVRInput.Button.Four);

        if (Physics.Raycast(ray, out hit))
        {
            GameObject objectHit = hit.transform.gameObject;
            Rigidbody rb = objectHit.GetComponent<Rigidbody>();

            if (objectHit.CompareTag("Furniture"))
            {
                if (LI == true && LH == true && Y == true)
                {
                    objectHit.transform.parent = leftHand.transform;
                    l = true;
                    rb.isKinematic = true;
                    DetectThrownObject.furniture = true;
                }else if (RI == true && RH == true && B == true)
                {
                    objectHit.transform.parent = rightHand.transform;
                    r = true;
                    rb.isKinematic = true;
                    DetectThrownObject.furniture = true;
                }
                
            }
           


            // Do something with the object that was hit by the raycast.
        }
            if (l == true && LI == false || l == true && LH == false || l == true && Y == false)
            {
                leftHand.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
                leftHand.transform.DetachChildren();
                l = false;
                DetectThrownObject.furniture = false;
            }
            if (r == true && RI == false || r == true && RH == false || r == true && B == false)
            {
                rightHand.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
                rightHand.transform.DetachChildren();
                 r = false;
                DetectThrownObject.furniture = false;
            }
        
    }

}
