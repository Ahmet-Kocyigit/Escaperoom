using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class codeChecker : MonoBehaviour
{
    private TextMeshPro input;
    private bool firstInputIsCorrect;


	// Use this for initialization
	void Start () {
		input = gameObject.transform.GetComponent<TextMeshPro>();
	    firstInputIsCorrect = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (firstInputIsCorrect==false)
	    {
	        if (input.text.Equals("1234"))
	        {
	            input.text = "Correct";
	            firstInputIsCorrect = true;
	        }
        }
	    
	}
}
