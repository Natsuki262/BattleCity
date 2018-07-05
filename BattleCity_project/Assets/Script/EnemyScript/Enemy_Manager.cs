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
        maxEntryNum =4;
        elapsedTime = 0.0f;
        nextEntryTime = 3.0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
		//画面上に出現する最大数を超えたら何もしない
        if(numEnemy >= maxEntryNum)
        {
            return;
        }

        //経過時間を足す
        elapsedTime += Time.deltaTime;

        //経過時間が経ったら敵出現
        if(elapsedTime > nextEntryTime)
        {
            elapsedTime = 0.0f;

            EnemyEntry();
        }
	}

    //----------------------------------------
    // 敵を指定位置から出現させる
    //----------------------------------------
    void EnemyEntry()
    {
        GameObject.Instantiate(enemySet[0], transform.position, transform.rotation);

        numEnemy++;
        elapsedTime = 0.0f;
    }
}
