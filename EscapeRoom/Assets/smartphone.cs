using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smartphone : MonoBehaviour {

    GameObject _samuel;
    GameObject _error;
    Boolean _called;
    // Use this for initialization
    void Start()
    {
        _error.active = false;
        _samuel.active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
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

    void CallSam()
    {
        _samuel.active = true;
        _error.active = false;
        _called = true;
    }
}
