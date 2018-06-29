/******************************
   普通敵戦車の処理
*******************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Normal : Enemy_Base
{

	// Use this for initialization
	IEnumerator Start ()
    {
        rotationVector = VECTOR_DOWN; //最初は下向き
        enemySpeed = 0.03f; //スピードの設定

        timeOut = Random.Range(1.0f, 3.0f); //終了時間の設定
        

        while (true)
        {
            //砲塔に弾を設置する
            Instantiate(bltObj, transform.position, transform.rotation);
            yield return new WaitForSeconds(2.0f);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        //経過時間を取得
        timeElapsed += Time.deltaTime;

        //敵戦車を移動させる
        EnemyMove();

        //設定時間を過ぎたらランダムに新しい方向を向く
        if (timeElapsed >= timeOut)
        {
            rotationVector = Random.Range(1, 4);

            timeElapsed = 0.0f;
            timeOut = Random.Range(1f, 3f);
        }
    }

    //------------------------------------------
    // 敵戦車を移動させる
    //------------------------------------------
    public override void EnemyMove()
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

        transform.position = enemyPosition;
    }
}

