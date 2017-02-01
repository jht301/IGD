using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCollection : MonoBehaviour {
    
    

	void Start () {
        
	}
     void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        obj.GetComponent<PlayerMngmt>().parts += 1;
        
       
        Destroy(gameObject);
        

    } 
}
