using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Object = System.Object;
using Random = System.Random;

public class QuestionController : MonoBehaviour {

	// Use this for initialization
    private string currentQuestion;

    private Boolean canAnswer = true;

    private bool[] corrects = {false, false, false};

    private string[] answers = {"session", "transport", "network"};
    

    public  GameObject console1;
    public GameObject console2;
    public GameObject console3;

    public AudioClip clip;
    public AudioSource source;

    void Start ()
	{
	    GetComponent<TextMesh>().text = "What is missing?" + Environment.NewLine + "1. application" + Environment.NewLine + "2. Presentation" + Environment.NewLine + "3. ?" + Environment.NewLine + "4. ?" + Environment.NewLine + "5. ?" + Environment.NewLine + "6. Data link" + Environment.NewLine + "7. Physical";
	    source.clip = clip;
	}
	
	// Update is called once per frame
	void Update () {

    }

   

    public void CheckAnswer(string value, int consoleNumber)
    {
        if (value == answers[consoleNumber])
        {
            corrects[consoleNumber] = true;
        }

        if (corrects[0] && corrects[1] && corrects[2])
        {
            source.Play();
            //open box
            GetComponent<TextMesh>().text = "Correct!";

        }
    }
}
