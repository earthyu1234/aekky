using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDownTime : MonoBehaviour {
	public string LevelLoad;
	public float timer = 10f;
	public Text timerSeconds;


	void Start () 
	{

		timerSeconds = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString("f2");
		if (timer <= 0)
		{
		
		Application.LoadLevel(LevelLoad);
	  
		}
		
	}
}
