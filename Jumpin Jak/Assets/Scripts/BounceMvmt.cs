using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceMvmt : MonoBehaviour {
    public int jumpHeight;                  //bouncing
    public float moveX;                     //moving forward
    public bool isMovingLeft = false;       //check if the player is moving left to use in camera script


    //public GameObject noBack;
    //public GameObject floor;
	


	void Start () {
     
	}
	
	
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            isMovingLeft = true;                            //changes is moving left
            transform.position -= new Vector3(moveX, 0, 0);
        }
        else {
            isMovingLeft = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveX, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D jump)
    {
        if (jump.gameObject.name != "backWall")
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpHeight;
           
        }
    } 
}


