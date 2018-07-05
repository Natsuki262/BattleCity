using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    GameObject eMove;
    Enemy_Normal emScript;

    //public GameObject eNormal;
    //float enemyVector;

	// Use this for initialization
	void Start ()
    {
        eMove = GameObject.Find("Enemy_Normal");
        emScript = eMove.GetComponent<Enemy_Normal>();

        //enemyVector = eNormal.transform.localRotation.z;

        if(emScript.rotationVector == 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 5.0f);
        }
        else if (emScript.rotationVector == 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -5.0f);
        }
        else if (emScript.rotationVector == 3)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);
        }
        else if (emScript.rotationVector == 4)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5.0f, 0.5f);
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

}
