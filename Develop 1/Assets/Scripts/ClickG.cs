﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickG : MonoBehaviour {

	public static string nameofobj;
	public GameObject Next;

	// Use this for initialization
	void Start () {
		Next.active = false;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()

	{

	    nameofobj = gameObject.name;
		
		Next.active = !Next.active;


		

	}
}

