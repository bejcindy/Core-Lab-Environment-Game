using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrepreneurTrigger : MonoBehaviour
{
    private bool sunTriggered = false;
    bool exit = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !sunTriggered)
        {
            sunTriggered = true;
            Sun.sundown = true;
            //Debug.Log("true");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")&&!exit)
        {
            DataHolder.count++;
            exit = true;
        }
    }
}
