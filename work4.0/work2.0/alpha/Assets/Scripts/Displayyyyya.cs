using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Displayyyyya : MonoBehaviour
{

    public static string nameofobj;

    public GameObject Next;
    public GameObject Next1;
    public GameObject Next2;
    public GameObject Next3;
    public GameObject Next4;
    public GameObject Next5;
    // Use this for initialization
    void Start()
    {
        Next.active = false;
        Next1.active = false;
        Next2.active = false;
        Next3.active = false;
        Next4.active = false;
        Next5.active = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()

    {

        nameofobj = gameObject.name;

       


        Next.active = !Next.active;
        Next1.active = !Next1.active;
        Next2.active = !Next2.active;
        Next3.active = !Next3.active;
        Next4.active = !Next4.active;
        Next5.active = !Next5.active;

    }
}
