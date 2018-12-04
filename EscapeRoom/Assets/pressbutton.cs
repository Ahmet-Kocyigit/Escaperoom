using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.VR;

public class pressbutton : MonoBehaviour
{
    private TextMeshPro input;
    private string inputString;
    private TextMeshPro screen;
    private bool CanPress = true;
    private int max_time = 1;
    private float timer = 0f;

    // Use this for initialization
    void Start () {
	    input = gameObject.transform.GetChild(0).GetComponent<TextMeshPro>();
        screen = GameObject.Find("keypad_console_screen").transform.GetChild(0).GetComponent<TextMeshPro>();
        
	}

    // Update is called once per frame
    void Update () {
        if (!CanPress)
        {
            timer += Time.deltaTime;
            if (timer >= max_time)
            {
                CanPress = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (CanPress)
        {
            if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
            {
                inputString = input.text;
                print(inputString);
                screen.text += inputString;
            }
            
        }
        
    }
}
