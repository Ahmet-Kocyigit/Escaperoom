using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Valve.VR;

public class Pressable : MonoBehaviour {

    private int max_time = 1;
    private float timer = 0f;
    private bool CanPress = true;
    private bool IsOn = false;
    private Light light1;
    private Light light2;
    private Light light3;
    private Light light4;

    // Use this for initialization
    void Start ()
    {

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
                    light1 = GameObject.Find("light_wall_1").transform.GetChild(0).GetComponent<Light>();
                    light1.color = Color.magenta;
                    light2 = GameObject.Find("light_wall_2").transform.GetChild(0).GetComponent<Light>();
                    light2.color = Color.magenta;
                    light3 = GameObject.Find("light_wall_3").transform.GetChild(0).GetComponent<Light>();
                    light3.color = Color.magenta;
                    light4 = GameObject.Find("light_wall_4").transform.GetChild(0).GetComponent<Light>();
                    light4.color = Color.magenta;
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
