using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConsoleController : MonoBehaviour
{

    public QuestionController QuestionController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
          GameObject.Find("big_screen").transform.GetChild(0).GetComponent<QuestionController>().CheckAnswer(Convert.ToInt32(transform.GetChild(0).GetComponent<TextMeshPro>().text));
    }
}
