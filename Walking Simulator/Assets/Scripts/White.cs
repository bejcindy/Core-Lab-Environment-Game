using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class White : MonoBehaviour
{
    public static bool w;
    public static int o;
    Color32 c = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        w = false;
        o = 0;
    }

    // Update is called once per frame
    void Update()
    {
        c.a = (byte)o;
        //DontDestroyOnLoad(gameObject);
        if (w==true)
        {
            GetComponent<Image>().color = c;
            o++;
            if (o >= 255)
            {
                w = false;
            }
        }else if(w==false && GameManager.reset==true)
        {
            GetComponent<Image>().color = c;
            o--;
            if (o <= 0)
            {
                GameManager.reset = false;
            }
        }
    }
}
