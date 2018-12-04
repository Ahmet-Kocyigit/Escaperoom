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
    private int[] answers = new int[3];
    public int correctAnswer;

    private Boolean canAnswer = true;
    

    public  GameObject console1;
    public GameObject console2;
    public GameObject console3;

    public AudioClip clip;
    public AudioSource source;

    public AudioClip clipWrong;

    void Start ()
	{
        ChangeQuestion();
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void ChangeQuestion()
    {
       Random r = new Random();
        int number1 = r.Next(100);
        int number2 = r.Next(100);

        int solution = number1 + number2;
        int wrong1 = solution - r.Next(15);
        int wrong2 = solution + r.Next(12);

        int startIndex = r.Next(3);
        answers[startIndex] = solution;
        correctAnswer = startIndex;
        
        
            startIndex++;
            if (startIndex == 3)
            {
                startIndex = 0;
            }

        answers[startIndex] = wrong1;

        startIndex++;
        if (startIndex == 3)
        {
            startIndex = 0;
        }

        answers[startIndex] = wrong2;



        currentQuestion = Convert.ToString(number1, 2) + " + " + Convert.ToString(number2, 2) + " = ?";


        console1.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = answers[0].ToString();
        console2.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = answers[1].ToString();
        console3.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = answers[2].ToString();
        GetComponent<TextMesh>().text = currentQuestion;
    }

    public void CheckAnswer(int value)
    {
        if (canAnswer)
        {
            if (value == answers[correctAnswer])
            {
                GetComponent<TextMesh>().text = "I Have Had It With \n These Motherf*cking Snakes \n On This Motherf*cking Plane!";
                console1.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = String.Empty;
                console2.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = String.Empty;
                console3.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text = String.Empty;
                source.clip = clip;
                source.Play();

                canAnswer = false;
            }
            else
            {
                ChangeQuestion();
                source.clip = clipWrong;
                source.Play();
            }
        }

        
    }
}
