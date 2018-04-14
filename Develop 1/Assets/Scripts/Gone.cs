using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gone : MonoBehaviour {

	public static string nameofobj;


	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()

	{

	    nameofobj = gameObject.name;
		Destroy (gameObject);



		

	}
}
