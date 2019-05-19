using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switch_test : MonoBehaviour
{
    public GameObject cameraFPS;
    public GameObject cameraTPS;

    AudioListener cameraFPSAudioLis;
    AudioListener cameraTPSAudioLis;
    // Start is called before the first frame update
    void Start()
    {
        cameraFPSAudioLis = cameraFPS.GetComponent<AudioListener>();
        cameraTPSAudioLis = cameraTPS.GetComponent<AudioListener>();

        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera();
    }
    public void cameraPositionM() {
        cameraChangeCounter();
    }
    void switchCamera() {
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraChangeCounter();
        }
    }

    void cameraChangeCounter() {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    void cameraPositionChange(int camPosition) {
        if (camPosition > 1)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if(camPosition == 0)
        {
            cameraFPS.SetActive(true);
            cameraFPSAudioLis.enabled = true;

            cameraTPS.SetActive(false);
            cameraTPSAudioLis.enabled = false;
        }

        if (camPosition == 1) {
            cameraTPS.SetActive(true);
            cameraTPSAudioLis.enabled = true;

            cameraFPS.SetActive(false);
            cameraFPSAudioLis.enabled = false;
        }
    }
}
