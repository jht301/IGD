using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMngmt : MonoBehaviour {
    public int parts;
    public string partCounter;
    public Text Counter;
    
	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
        partCounter = "Parts:" +parts + "/5";
        Counter.text = partCounter;

    }
}
