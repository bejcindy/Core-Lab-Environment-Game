using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Player;
    public GameObject StartMenu;
    public GameObject sun;
    public static bool reset;

    GameObject[] specialGraves;
    AudioSource audio;
    Vector3 pp,sp;
    Vector3 pr,sr;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        PauseMenu.SetActive(false);
        StartMenu.SetActive(true);
        reset = false;
        pp = Player.transform.position;
        pr = Player.transform.eulerAngles;
        sp = sun.transform.position;
        sr = sun.transform.eulerAngles;
        specialGraves = GameObject.FindGameObjectsWithTag("ImportantPeople");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")){
            PauseMenu.SetActive(true);
        }
        if (ExitScene.end == true && White.o >= 255)
        {
            Player.transform.position = pp;
            //Player.transform.eulerAngles = pr;
            sun.transform.position = sp;
            sun.transform.eulerAngles = sr;
            DataHolder.count = 0;
            StartMenu.SetActive(true);
            foreach (GameObject grave in specialGraves)
            {
                audio = grave.GetComponent<AudioSource>();
                audio.volume = 0.5f;
            }
            reset = true;
        }
    }
}
