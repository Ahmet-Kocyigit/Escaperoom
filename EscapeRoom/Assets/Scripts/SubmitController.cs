using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SubmitController : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;

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
            light1.GetComponent<LighController>().setColor("white");
            light2.GetComponent<LighController>().setColor("white");
            light3.GetComponent<LighController>().setColor("white");
            light4.GetComponent<LighController>().setColor("white");
            light5.GetComponent<LighController>().setColor("white");

        }
        else
        {
            light1.GetComponent<LighController>().setColor("green");
            light2.GetComponent<LighController>().setColor("green");
            light3.GetComponent<LighController>().setColor("green");
            light4.GetComponent<LighController>().setColor("green");
            light5.GetComponent<LighController>().setColor("green");
            counter = 1;

        }

        return;
    }

    public void addAnswer(string value)
    {
        if (counter >5)
       {
            return;
        }

        this.answer += value;
        messageScreen.gameObject.GetComponent<TextMesh>().text = answer;
        switch (counter)
        {
            case 1:
                light1.GetComponent<LighController>().setColor("blue");
                break;
            case 2:
                light2.GetComponent<LighController>().setColor("blue");
                break;
            case 3:
                light3.GetComponent<LighController>().setColor("blue");
                break;
            case 4:
                light4.GetComponent<LighController>().setColor("blue");
                break;
            case 5:
                light5.GetComponent<LighController>().setColor("blue");
                break;
        }

        counter++;
    }
}
