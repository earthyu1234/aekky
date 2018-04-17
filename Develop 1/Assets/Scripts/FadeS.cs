using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeS : MonoBehaviour {


	public Color loadToColor = Color.white;

	public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()

	{
		Initiate.Fade(scene,loadToColor,0.5f);	

			

	}
}
