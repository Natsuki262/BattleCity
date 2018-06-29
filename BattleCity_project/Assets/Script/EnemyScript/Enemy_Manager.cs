/************************************
   敵戦車を生成する
*************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : MonoBehaviour
{
    [SerializeField]
    GameObject[] enemySet;  //出現する敵を格納する

    [SerializeField]
    float nextEntryTime;  //次の敵が出現する時間

    [SerializeField]
    int maxEntryNum;  //出現する敵の最大数

    private int numEnemy;  //出現した敵の数

    private float elapsedTime;  //待ち時間計測

	// Use this for initialization
	void Start ()
    {
        numEnemy = 0;
        elapsedTime = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
