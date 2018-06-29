using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move1 : MonoBehaviour
{


    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    Vector2 Position;
    public GameObject P_Bullet;
    public int X_Dintdirection;
    public int Y_Dintdirection;
    public float Z_Dintdirection;
    public int speed = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Player_Move();
        BulletShot();

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
                //transform.Rotate(new Vector3(0, 0, -90));
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
                //transform.eulerAngles = new Vector3(X_Dintdirection, Y_Dintdirection, Z_Dintdirection);
                //print(transform.eulerAngles.z);
                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
               
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
                   //transform.Rotate(new Vector3(0, 0, 90));
                   this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 270.0f);
                //print(transform.eulerAngles.z);
                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
            }
            }
            if (Input.GetKey(KeyCode.W))
            {
                Position.y += SPEED.y;
                transform.position = Position;
                if (Input.GetKeyDown(KeyCode.W))
                {
                //transform.Rotate(new Vector3(0, 0, -180));
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                // print(transform.eulerAngles.z);
                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);

            }
            }

            if (Input.GetKey(KeyCode.S))
            {
                Position.y -= SPEED.y;
                transform.position = Position;
                if (Input.GetKeyDown(KeyCode.S))
                {
                // transform.Rotate(new Vector3(0, 0, 180));
                // print(transform.eulerAngles.z);
                Z_Dintdirection = transform.eulerAngles.z;
                Debug.Log(Z_Dintdirection);
                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 180.0f);
                }

            }
        }
       void BulletShot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(P_Bullet, transform.position, Quaternion.identity);
            GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
            if (Z_Dintdirection==90)
            {
                //Instantiate(P_Bullet, transform.position, Quaternion.identity);
               //GameObject P_Bullet=GameObject.Instantiate(P_Bullet)as GameObject;

            }
        }
            
        }
    }




 
