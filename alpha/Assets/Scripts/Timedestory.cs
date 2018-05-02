using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timedestory : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void OnMouseDown() {
		Destroy(gameObject, 5f);
		
	}
}
