/*****************************************************
  全ての敵戦車に共通する要素の設計(基本クラス)
******************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{ 
    //定数の宣言
    public const int VECTOR_UP = 1;     //上向き
    public const int VECTOR_DOWN = 2;   //下向き
    public const int VECTOR_RIGHT = 3;  //右向き
    public const int VECTOR_LEFT = 4;   //左向き

    //変数の宣言
    protected Vector3 enemyPosition; //敵戦車の位置

    public GameObject bltObj; //弾のゲームオブジェクト
    public GameObject eBullet;

    public int rotationVector;  //敵戦車の向き
    public float enemySpeed;    //スピード

    public float timeOut;      //方向転換終了時間
    public float timeElapsed;  //方向転換経過時間

    public float nextBulletTime;     //次の弾発射時間
    public float elapsedBulletTime;  //弾発射経過時間

    // Use this for initialization
    void Start()
    { 

        nextBulletTime = 3.0f;
        elapsedBulletTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedBulletTime += Time.deltaTime;
    }


    //-----------------------------------------
    // 敵戦車を移動させる
    //-----------------------------------------
    public virtual void EnemyMove()
    {
        switch (rotationVector)
        {
            //上移動
            case VECTOR_UP:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                enemyPosition.y += enemySpeed;
                break;

            //下移動
            case VECTOR_DOWN:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
                enemyPosition.y -= enemySpeed;
                break;

            //右移動
            case VECTOR_RIGHT:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
                enemyPosition.x += enemySpeed;
                break;

            //左移動
            case VECTOR_LEFT:
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                enemyPosition.x -= enemySpeed;
                break;

            default:
                break;
        }
    }
}