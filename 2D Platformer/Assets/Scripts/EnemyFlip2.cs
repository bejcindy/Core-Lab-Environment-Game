//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnemyFlip2 : MonoBehaviour
//{
//    public GameObject enemy;
//    Rigidbody2D rb;
//    SpriteRenderer sr;
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        sr = enemy.GetComponent<SpriteRenderer>();
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.CompareTag("ground"))
//        {
//            sr.flipX = false;
//            EnemyPatrol.dir = -EnemyPatrol.dir;
//        }
//    }
//}
