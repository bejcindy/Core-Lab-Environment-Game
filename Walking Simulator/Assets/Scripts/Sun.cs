using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    public static bool sundown;
    // Start is called before the first frame update
    void Start()
    {
        sundown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (sundown == true){
            StartCoroutine(RotateSun());
        }
    }
    IEnumerator RotateSun()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 10f * Time.deltaTime);
        transform.LookAt(Vector3.zero);
        yield return new WaitForSeconds(1.5f);
        sundown = false;
    }
}
