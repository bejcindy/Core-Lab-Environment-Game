using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitScene : MonoBehaviour
{
    public static bool end;
    // Start is called before the first frame update
    void Start()
    {
        end = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            White.w = true;
            end = true;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
