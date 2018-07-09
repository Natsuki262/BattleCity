using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SO05 : MonoBehaviour
{
    //プレハブ化したオブジェクトを表示
    public GameObject ExploadObj;
    public GameObject ExploadPos;
    // Update is called once per frame
    void Update()
    {
        //upを押したら
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(ExploadObj, ExploadPos.transform.position, Quaternion.identity);
        }
    }
}