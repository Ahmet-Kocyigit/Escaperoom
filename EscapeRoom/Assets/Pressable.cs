using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    private Light UvLight;
    private DistanceCalculator distanceCalculator;
    public AudioClip clip;
    public AudioSource source;

    private const float INTENSELIGHT = 3f;

    // Use this for initialization
    void Start ()
    {
        light1 = GameObject.Find("CeilingLight").transform.GetChild(0).GetComponent<Light>();
        light2 = GameObject.Find("CeilingLight2").transform.GetChild(0).GetComponent<Light>();
        UvLight = GameObject.Find("UVLight").transform.GetChild(0).GetComponent<Light>();
        distanceCalculator = GameObject.Find("UVLight").GetComponent<DistanceCalculator>();
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
            source.clip = clip;
            if (!IsOn)
            {
                if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
                {
                    source.Play();

                    transform.Rotate(180, 0, 0);
                    CanPress = false;
                    IsOn = true;
                    
                    light1.color = Color.black;
                    light2.color = Color.black;
                    UvLight.color = Color.magenta;
                    UvLight.intensity = INTENSELIGHT;
                    distanceCalculator.isActive = true;
                }
            }
            else
            {
                if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
                {
                    source.Play();

                    transform.Rotate(180, 0, 0);
                    CanPress = false;
                    IsOn = false;
                    
                    light1.color = Color.white;
                    light2.color = Color.white;
                    UvLight.color = Color.black;
                    distanceCalculator.isActive = false;
                }
            }
           
        }
        
    }
    
    
}
