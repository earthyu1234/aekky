using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageup : MonoBehaviour {

	public Image image;
	void Start () {

		image.enabled = false;
		
	}
	
	// Update is called once per frame
	void OnMouseDown () {

		image.enabled = !image.enabled;
	}
}
