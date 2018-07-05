using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    public GameObject bullet;

    public Transform Instance;


    public float speed = 1000;

    // Use this for initialization
    void Start ()
    {
       
        
           
           
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(bullet) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(force);
            // 弾丸の位置を調整
            bullets.transform.position = Instance.position;

        }
    }
    
}


