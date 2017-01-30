using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {
    public GameObject player;
    BounceMvmt moveScript;
    bool isFollowing = false;
    float currentCameraX = 0;

	// Use this for initialization
	void Start () {
        moveScript = player.GetComponent<BounceMvmt>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x >= currentCameraX && !isFollowing) {
            isFollowing = true;
        }

        if (!moveScript.isMovingLeft && isFollowing)
        {
            Vector3 v = transform.position;
            currentCameraX = player.transform.position.x;
            v.x = currentCameraX;
            transform.position = v;
        }
        else {
            isFollowing = false;
        }

	}
}
