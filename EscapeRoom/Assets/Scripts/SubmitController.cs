using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class SubmitController : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject door;

    public GameObject messageScreen;
    

    public string answer;
    public string correctAnswer;

    public string errormessage;
    public bool isSolved =false;
    private int counter = 1;

    public HoverButton hoverButton;


    // Use this for initialization
    void Start()
    {

        hoverButton.onButtonDown.AddListener(OnButtonDown);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnButtonDown(Hand hand)
    {
        

        if (answer != correctAnswer) //when the wrong sequence is entered false needs to be replaced
        {
            answer = "";
            light1.GetComponent<LighController>().setColor("white");
            light2.GetComponent<LighController>().setColor("white");
            light3.GetComponent<LighController>().setColor("white");
            light4.GetComponent<LighController>().setColor("white");
            light5.GetComponent<LighController>().setColor("white");


            messageScreen.gameObject.GetComponent<TextMeshPro>().text = errormessage;
        }
        else
        {
            answer = "";
            light1.GetComponent<LighController>().setColor("green");
            light2.GetComponent<LighController>().setColor("green");
            light3.GetComponent<LighController>().setColor("green");
            light4.GetComponent<LighController>().setColor("green");
            light5.GetComponent<LighController>().setColor("green");
            counter = 1;

            isSolved = true;
            door.GetComponent<DoorController>().OpenDoor();

            messageScreen.gameObject.GetComponent<TextMeshPro>().text = "correct answer";

        }

        return;
    }


    void OnCollisionEnter(Collision collision)
    {
    }

    public void addAnswer(string value)
    {
        if (isSolved)
            return;

        if (counter >5)
       {
            return;
        }

        this.answer += value;
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
