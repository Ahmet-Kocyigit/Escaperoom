using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConsoleController : MonoBehaviour
{

    private int max_time = 3;
    private float timer = 0f;
    private bool CanAnswer = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!CanAnswer)
	    {
	        timer += Time.deltaTime;
	        if (timer >= max_time)
	        {
	            CanAnswer = true;
	        }
        }
	    
	}

    void OnCollisionEnter(Collision col)
    {
        if (CanAnswer)
        {
            //GameObject.Find("big_screen").transform.GetChild(0).GetComponent<QuestionController>().CheckAnswer(Convert.ToInt32(transform.GetChild(0).GetComponent<TextMeshPro>().text));
            CanAnswer = false;
        }
    }
}
