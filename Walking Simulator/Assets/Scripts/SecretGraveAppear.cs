using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretGraveAppear : MonoBehaviour
{
    public GameObject secretGrave;
    public GameObject fireflies;

    GameObject[] specialGraves;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        secretGrave.SetActive(false);
        fireflies.SetActive(false);
        //secretGrave.SetActive(true);

        specialGraves = GameObject.FindGameObjectsWithTag("ImportantPeople");
    }

    // Update is called once per frame
    void Update()
    {
        if (DataHolder.count >= 9)
        {
            secretGrave.SetActive(true);
            fireflies.SetActive(true);
            foreach(GameObject grave in specialGraves)
            {
                audio = grave.GetComponent<AudioSource>();
                audio.volume = 0;
            }
        }
    }
}
