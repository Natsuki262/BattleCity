using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject playerBullet;
    public float playerSpeed;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * playerSpeed * Time.deltaTime;
            transform.LookAt(transform.position +Vector3.forward ,Vector3.up );
            //transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up);
            // this.transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
            //transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, -1));
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3. right* playerSpeed * Time.deltaTime; 
            transform.LookAt(transform.position+Vector3.forward,Vector3.right);
            //transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * playerSpeed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.forward,Vector3.down);
            //this.transform.rotation = Quaternion.FromToRotation(Vector3.down, transform.forward);
            //transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
            transform.LookAt(transform.position + Vector3.forward,Vector3.left);
            //this.transform.rotation = Quaternion.FromToRotation(Vector3.left, transform.forward);
            //transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 0, 1));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(playerBullet, transform.position, transform.rotation);
            //transform.LookAt(transform.position + Vector3.right);
        }

    }
}
