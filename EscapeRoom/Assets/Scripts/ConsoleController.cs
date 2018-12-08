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
        if (col.gameObject.GetComponent<ValueController>() != null)
        {
            if (true)
            {
                int console = Convert.ToInt32(GetComponent<ValueController>().value);
                print("Console: " + console + " set to " + col.gameObject.GetComponent<ValueController>().value.ToString());
                GameObject.Find("big_screen").transform.GetChild(0).GetComponent<QuestionController>().CheckAnswer(col.gameObject.GetComponent<ValueController>().value, console);
                CanAnswer = false;
            }
        }
    }
}
