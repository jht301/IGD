﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.GetComponent<PlayerMngmt>().parts == 5)
        {
            SceneManager.LoadScene("level2");
        }
    }
}
