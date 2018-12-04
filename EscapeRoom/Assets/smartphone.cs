using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smartphone : MonoBehaviour {

    public GameObject samuel;
    public GameObject Error;
    // Use this for initialization
    void Start()
    {

        samuel.active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        //0.0068
        samuel.active = true;
        print("aaaaaaaa");
    }
}
