using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Object = System.Object;

public class QuestionController : MonoBehaviour {

	// Use this for initialization
    private String[] questions = new []{"0110 1000 + 0010 0011","0000 0000 + 0000 0000", "0000 0000 + 0000 0000"};
    private int[] solutions1 = new[] {56, 64, 80};
    private int currentQuestion;

    public  GameObject console1;
    public GameObject console2;
    public GameObject console3;

    void Start ()
	{
	    currentQuestion = 0;

	    GameObject.Find("console").GetComponent<TextMeshPro>().text = solutions1[0].ToString();
	    GameObject.Find("console2").GetComponent<TextMeshPro>().text = solutions1[1].ToString();
	    GameObject.Find("console3").GetComponent<TextMeshPro>().text = solutions1[2].ToString();

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
