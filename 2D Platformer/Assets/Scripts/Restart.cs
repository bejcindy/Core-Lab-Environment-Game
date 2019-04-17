using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(DataHolder.level);
        }
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        //RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        //if (hit.collider != null)
        //{
        //    SceneManager.LoadScene("Title");
        //}
    }
}
