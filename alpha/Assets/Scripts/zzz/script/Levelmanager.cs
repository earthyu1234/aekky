using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requseted for:" + name);
        Application.LoadLevel(name);
    }


    void Update()
    {

    }
}
