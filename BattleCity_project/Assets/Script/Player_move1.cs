using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move1 : MonoBehaviour {


  public Vector2 SPEED = new Vector2(0.05f, 0.05f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
  {
    Player_Move();
	}
  /*
   * -------------------------
   Player移動関数* 
   ---------------------------*/
  void Player_Move()
  {
    Vector2 Position = transform.position;
      if(Input.GetKey("left"))
    {
      Position.x -= SPEED.x;
    }
    
  }
   
}
