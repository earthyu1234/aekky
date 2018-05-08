using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {
    public Text displayText;
    public string textToDisplay;
    void Start()
    {
        displayText.text = "";
    }
    public void DisplayText()
    {
        displayText.text = "";
        displayText.text = "" + textToDisplay;
    }

    
}
