/***********************************************************
   敵戦車の移動・弾発射・衝突判定を行う
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public const int VECTOR_UP = 1;     //上向き
    public const int VECTOR_DOWN = 2;   //下向き
    public const int VECTOR_RIGHT = 3;  //右向き
    public const int VECTOR_LEFT = 4;   //左向き
    public int rotationVector;   //方向転換

    private float speed = 0.03f;  //移動スピード
    private int beforeVector;     //直前の方向

    private float timeOut;       //終了時間
    private float timeElapsed;   //経過時間

    Vector3 position;  //位置情報

    public GameObject bltObj;    //ゲームオブジェクトの取得

	// Use this for initialization
	IEnumerator Start ()
    {
        position = transform.position;
        timeOut = Random.Range(1f, 3f);

        rotationVector = VECTOR_DOWN;  //最初は下向き
        beforeVector = rotationVector;

        while(true)
        {
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
            //直前と同じ方向を向かないようにする
            do
            {
                rotationVector = Random.Range(1, 4);

            } while (rotationVector == beforeVector);
            

            timeElapsed = 0.0f;
            timeOut = Random.Range(1f, 3f);
        }
	}

    //------------------------------------------------
    // エネミーを方向転換し、前方に移動させる
    //------------------------------------------------
    public void EnemyMove()
    {
        switch(rotationVector)
        {
            //上移動
            case VECTOR_UP:
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                position.y += speed;
                break;
            
            //下移動
            case VECTOR_DOWN:
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
                position.y -= speed;
                break;

            //右移動
            case VECTOR_RIGHT:
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
                position.x += speed;
                break;

            //左移動
            case VECTOR_LEFT:
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                position.x -= speed;
                break;

            default:
                break;
        }

        transform.position = position;
    }
}
