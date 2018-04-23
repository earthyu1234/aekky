using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {
    //name of the scene you want to load

	public Color loadToColor = Color.white;
	
	// Update is called once per frame
	public void LoadLevel(string scene)  
        //Button to load the new scene
		{
			Initiate.Fade(scene,loadToColor,0.5f);	
		}
	
}
