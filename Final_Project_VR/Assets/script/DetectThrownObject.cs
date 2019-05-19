using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectThrownObject : MonoBehaviour
{

    public GameObject excMark;
    bool a;
    float t = 2;
    public static bool furniture;

    // Start is called before the first frame update
    void Start()
    {
        excMark.SetActive(false);
        a = false;
        furniture = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (a)
        //{
        //    t -= Time.deltaTime;
        //}
        //if (t == 0)
        //{
        //    a = false;
        //    excMark.SetActive(false);
        //    t = 2;
        //}
        if (furniture == true)
        {
            excMark.SetActive(true);
            StartCoroutine(ExcMarkAppear());
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            excMark.SetActive(true);
            StartCoroutine(ExcMarkAppear());
            a = true;
        }
    }
    IEnumerator ExcMarkAppear()
    {
        yield return new WaitForSeconds(2);
        excMark.SetActive(false);
    }
}
