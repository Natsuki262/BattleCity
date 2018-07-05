using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour

{
   

    public float speed = 5;
    public GameObject playerObject;
    Vector3 playerRotation;

    // Use this for initialization
    void Start ()
    {
        playerRotation = playerObject.transform.localEulerAngles;
      if(playerRotation.z==0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5.0f);

        }
       else if (playerRotation.z == -90)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);


        }
       else if (playerRotation.z == 180)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5.0f);

        }
        else if (playerRotation.z == 90)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5.0f, 0.0f);


        }





    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    
}


