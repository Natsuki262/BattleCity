using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    GameObject Player;
    GameObject Instance;
    public GameObject Bullet;
    public float speed;
    // Use this for initialization
    void Start ()
    { 
        Player = GameObject.Find("Player");
        Instance = GameObject.Find("Instance");
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //移動処理
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed = 1000;
           // Player.GetComponent().velocity = (Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed = 1000;
            ///Player.GetComponent().velocity = (Vector2.right * -speed * Time.deltaTime);
        }
        else
        {
            speed = 0;
            //Player.GetComponent().velocity = (Vector2.right * -speed * Time.deltaTime);
        }
    }
}
