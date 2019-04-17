using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour {

    public Text outPut;
    public GameObject prefab;

    private int[] numbers;

	// Use this for initialization
	void Start () {
        //StartCoroutine(MakeBlocks());

        numbers = new int[] { 11, 2, 54, 7 };

        for (int i = numbers.Length; i >-1; i--)
        {
            outPut.text += numbers[i].ToString()+"\n";
        }
    }
	
    //IEnumerator MakeBlocks()
    //{
    //    for (int i = 0; i < 20; i++)
    //    {
    //        for (int j = 0; j < 100; j++)
    //        {
    //            Vector3 pos = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
    //            Instantiate(prefab, pos, Quaternion.identity);
    //        }
    //        yield return null;
    //    }
    //}

    // Update is called once per frame
    void Update () {
		
	}
}
