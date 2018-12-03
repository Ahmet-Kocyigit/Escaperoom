using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour {

	// Use this for initialization
    private String[] questions = new []{"0110 1000 + 0010 0011","0000 0000 + 0000 0000", "0000 0000 + 0000 0000"};
    private int[] solutions = new[] {56, 64, 80};
    private int currentQuestion;

	void Start ()
	{
	    currentQuestion = 0;
	    GetComponent<TextMesh>().text = questions[currentQuestion];
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void ChangeQuestion()
    {
        currentQuestion++;
        if (currentQuestion >= 3)
        {
            currentQuestion = 0;
            GetComponent<TextMesh>().text = questions[currentQuestion];
        }
    }

    public void CheckAnswer(int value)
    {
        if (value == solutions[currentQuestion])
        {
            GetComponent<TextMesh>().text = "CORRECT !";
        }
        else
        {
            ChangeQuestion();
        }
    }
}
