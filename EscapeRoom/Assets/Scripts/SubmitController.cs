using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SubmitController : MonoBehaviour
{

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;

    public GameObject messageScreen;
    

    public string answer;
    public string correctAnswer;

    public string errormessage;

    private int counter = 1;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (!SteamVR_Input.__actions_default_in_GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
        {
            return;
        }

        if (answer!=correctAnswer) //when the wrong sequence is entered false needs to be replaced
        {
            counter = 1;
            light1 = light1.GetComponent<Light>();
            light1.intensity = 1.13f;
            light1.color = Color.white;
            light2 = light2.GetComponent<Light>();
            light2.intensity = 1.13f;
            light2.color = Color.white;
            light3 = light3.GetComponent<Light>();
            light3.intensity = 1.13f;
            light3.color = Color.white;
            light4 = light4.GetComponent<Light>();
            light4.intensity = 1.13f;
            light4.color = Color.white;
            light5 = light5.GetComponent<Light>();
            light5.intensity = 1.13f;
            light5.color = Color.white;

        }
        else
        {
            light1 = light1.GetComponent<Light>();
            light1.intensity = 1.13f;
            light1.color = Color.green;
            light2 = light2.GetComponent<Light>();
            light2.intensity = 1.13f;
            light2.color = Color.green;
            light3 = light3.GetComponent<Light>();
            light3.intensity = 1.13f;
            light3.color = Color.green;
            light4 = light4.GetComponent<Light>();
            light4.intensity = 1.13f;
            light4.color = Color.green;
            light5 = light5.GetComponent<Light>();
            light5.intensity = 1.13f;
            light5.color = Color.green;

            counter = 1;

        }

        return;
    }

    public void addAnswer(string value)
    {
        if (counter < 5)
        {
            return;
        }

        this.answer += value;

        switch (counter)
        {
            case 1:
                light1 = light1.GetComponent<Light>();
                light1.intensity = 1.13f;
                light1.color = Color.blue;
                break;
            case 2:
                light2 = light1.GetComponent<Light>();
                light2.intensity = 1.13f;
                light2.color = Color.blue;
                break;
            case 3:
                light3 = light1.GetComponent<Light>();
                light3.intensity = 1.13f;
                light3.color = Color.blue;
                break;
            case 4:
                light4 = light1.GetComponent<Light>();
                light4.intensity = 1.13f;
                light4.color = Color.blue;
                break;
            case 5:
                light5 = light1.GetComponent<Light>();
                light5.intensity = 1.13f;
                light5.color = Color.blue;
                break;
        }

        counter++;
    }
}
