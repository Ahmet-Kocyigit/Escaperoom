using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class smartphone : MonoBehaviour {

    public GameObject _samuel;
    public GameObject _error;
    public Boolean _called;
    // Use this for initialization
    void Start()
    {
        _error.active = true;
        _samuel.active = false;
        _called = true;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
        {

            if (!_called)
            {
                _samuel.active = false;
                _error.active = true;
            }
            else
            {
                _samuel.active = true;
                _error.active = false;
            }
        }

    }

    void CallSam()
    {
        _samuel.active = true;
        _error.active = false;
        _called = true;
    }
}
