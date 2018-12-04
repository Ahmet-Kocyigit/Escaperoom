using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Pressable : MonoBehaviour {

    private int max_time = 1;
    private float timer = 0f;
    private bool CanPress = true;
    private bool IsOn = false;

    // Use this for initialization
    void Start ()
    {
        RenderSettings.ambientLight = Color.white;
    }

    // Update is called once per frame
    void Update() {
        if (!CanPress)
        {
            timer += Time.deltaTime;
            if (timer >= max_time)
            {
                CanPress = true;
            }
        }
    }
    
   
    
    void OnCollisionEnter(Collision collision){
        if (CanPress)
        {
            if (!IsOn)
            {
                if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
                {
                    transform.Rotate(180, 0, 0);
                    CanPress = false;
                    IsOn = true;
                    RenderSettings.ambientLight = Color.magenta;
                }
            }
            else
            {
                if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
                {
                    transform.Rotate(180, 0, 0);
                    CanPress = false;
                    IsOn = false;
                    RenderSettings.ambientLight = Color.white;
                }
            }
           
        }
        
    }
    
    
}
