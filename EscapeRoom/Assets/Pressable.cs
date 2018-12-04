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
    private Light light3;
    private Light light4;
    private TextMeshPro samText;
    private TextMeshPro obamaText;
    private TextMeshPro liamText;
    private TextMeshPro morganText;
    private const float INTENSELIGHT = 5f;

    // Use this for initialization
    void Start ()
    {
        light1 = GameObject.Find("light_wall_1").transform.GetChild(0).GetComponent<Light>();
        light2 = GameObject.Find("light_wall_2").transform.GetChild(0).GetComponent<Light>();
        light3 = GameObject.Find("light_wall_3").transform.GetChild(0).GetComponent<Light>();
        light4 = GameObject.Find("light_wall_4").transform.GetChild(0).GetComponent<Light>();
        samText = GameObject.Find("decorative_table_glass 1").transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
        obamaText = GameObject.Find("decorative_table_glass 1").transform.GetChild(1).GetChild(0).GetComponent<TextMeshPro>();
        liamText = GameObject.Find("decorative_table_glass 1").transform.GetChild(2).GetChild(0).GetComponent<TextMeshPro>();
        morganText = GameObject.Find("decorative_table_glass 1").transform.GetChild(3).GetChild(0).GetComponent<TextMeshPro>();
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
                    
                    light1.intensity = INTENSELIGHT;
                    light1.color = Color.magenta;
                    light2.intensity = INTENSELIGHT;
                    light2.color = Color.magenta;
                    light3.intensity = INTENSELIGHT;
                    light3.color = Color.magenta;
                    light4.intensity = INTENSELIGHT;
                    light4.color = Color.magenta;
                    
                    samText.text = "3456";
                    obamaText.text = "9874";
                    liamText.text = "3458";
                    morganText.text = "2255";
                }
            }
            else
            {
                if (SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
                {
                    transform.Rotate(180, 0, 0);
                    CanPress = false;
                    IsOn = false;

                    light1.intensity = 1.13f;
                    light1.color = Color.white;
                    light2.intensity = 1.13f;
                    light2.color = Color.white;
                    light3.intensity = 1.13f;
                    light3.color = Color.white;
                    light4.intensity = 1.13f;
                    light4.color = Color.white;

                    samText.text = "";
                    obamaText.text = "";
                    liamText.text = "";
                    morganText.text = "";
                }
            }
           
        }
        
    }
    
    
}
