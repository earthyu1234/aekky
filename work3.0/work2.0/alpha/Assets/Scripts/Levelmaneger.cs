using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmaneger : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requseted for:" + name);
        Application.LoadLevel(name);
    }



    // Update is called once per frame
    void Update()
    {

    }
}