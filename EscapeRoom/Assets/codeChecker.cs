﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class codeChecker : MonoBehaviour
{
    public string firstCode = "7368";
    public string secondCode = "5050";
    private TextMeshPro input;
    private bool firstInputIsCorrect;
    private bool secondInputIsActivated;
    public GameObject phone;
    public GameObject scanningStation;

    public GameObject numPad;


    // Use this for initialization
    void Start () {
		input = gameObject.transform.GetComponent<TextMeshPro>();
	    firstInputIsCorrect = false;
        secondInputIsActivated = false;
    }
	
	// Update is called once per frame
	void Update () {
	    if (firstInputIsCorrect==false)
	    {
	        if (input.text.Equals(firstCode))
	        {
	            input.text = "";
	            firstInputIsCorrect = true;
	            secondInputIsActivated = true;
                phone.GetComponent<smartphone>().CallSam();
            }
        }

	    if (secondInputIsActivated)
	        {
	            if (input.text.Equals(secondCode))
	            {
	                input.text = "Correct!";
                    
                    scanningStation.GetComponent<SnapController>().enable();
	            }
	        }
        }
	    
	}

