using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ffff : MonoBehaviour {

	public Image image;

	void Start () {

		image.enabled = false;
		
	}

	// Update is called once per frame
	public void OnTriggerEnter2D() {

		image.enabled = true;

	}
}
