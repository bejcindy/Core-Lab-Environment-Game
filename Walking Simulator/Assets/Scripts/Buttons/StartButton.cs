using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void StartB()
    {
        GameObject.Find("StartMenu").SetActive(false);
        //GameObject.Find("PauseMenu").SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
