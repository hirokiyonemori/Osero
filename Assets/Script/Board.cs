using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    //　ボードのプレハブ
    public GameObject squarePrefab;

    //　石のプレハブ
    public GameObject stonePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // ボードの作成
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; x < 8; x++)
            {
                Instantiate(squarePrefab, new Vector3(x, 0, y), Quaternion.identity);
            }
        }

        //　石を置く
        Instantiate(stonePrefab, new Vector3(3, 0.6f, 3), new Quaternion(180f, 0, 0f, 1.0f));
        Instantiate(stonePrefab, new Vector3(3, 0.8f, 4), Quaternion.identity);
        Instantiate(stonePrefab, new Vector3(4, 0.8f, 3), Quaternion.identity);
        Instantiate(stonePrefab, new Vector3(4, 0.6f, 4), new Quaternion(180f, 0, 0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

}

