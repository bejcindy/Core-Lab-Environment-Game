using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public float xMax, xMin, yMax, yMin;
    public GameObject coin;
    float t;
    int n;
    int total;
    

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;
        if (t <= 0)
        {
            n = Random.Range(1, 5);
            total += n;
            for (int i=0;i<n; i++)
            {
                Spawn();
            }
            t = 10;
        }
        if (PlayerMovement.collected == total)
        {
            ExitDoor.e = true;
        }
    }

    public void Spawn()
    {
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(coin, pos, Quaternion.identity);
    }
}
