using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move1 : MonoBehaviour
{


    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    Vector2 Position;
    public GameObject bullet;
    public int X_Dintdirection;
    public int Y_Dintdirection;
    public float Z_Dintdirection;
    public int speed = 10;
    public int testnum = 100;
    public int PlayerVector;
    //定数の宣言
    public const int VECTOR_UP = 1;
    public const int VECTOR_DOWN = 2;
    public const int VECTOR_RIGHT = 3;
    public const int VECTOR_LEFT = 4;

    // Use this for initialization
    void Start()
    {
       
        
            Instantiate (bullet, transform.position, transform.rotation);
			// 0.05秒待つ
			

        

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           GameObject obj=Instantiate(bullet, transform.position, transform.rotation);
            obj.GetComponent<Bullet>().playerRotation = transform.forward;
        }

        Player_Move();


    }    /*
         * -------------------------
         Player移動関数* 
         ---------------------------*/

    void Player_Move()
    {
        Position = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {

                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
                PlayerVector = VECTOR_LEFT;
            }
            Position.x -= SPEED.x;
            transform.position = Position;
        }
        transform.position = Position;

        if (Input.GetKey(KeyCode.D))
        {
            //Dキーが押されたら右に動く
            Position.x += SPEED.x;
            transform.position = Position;
            if (Input.GetKeyDown(KeyCode.D))
            {

                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);

                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
            }
        }
        //Wキー押されたら上に動く
        if (Input.GetKey(KeyCode.W))
        {
            Position.y += SPEED.y;
            transform.position = Position;
            if (Input.GetKeyDown(KeyCode.W))
            {

                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);

            }
        }

        //Sキーを押されたら下に動く
        if (Input.GetKey(KeyCode.S))
        {
            Position.y -= SPEED.y;
            transform.position = Position;
            if (Input.GetKeyDown(KeyCode.S))
            {

                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
            }

        }
    }
    void Bulletgene()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            //GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
            bullet.GetComponent<Bullet>().playerRotation= transform.forward;
        }

    }

}

















