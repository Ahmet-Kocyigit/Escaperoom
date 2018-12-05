using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class codeChecker : MonoBehaviour
{
    private TextMeshPro input;
    private bool firstInputIsCorrect;
    private int max_time = 5;
    private float timer = 0f;
    private bool CanPress = true;


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
	            input.text = "Correct!";
	            firstInputIsCorrect = true;
	        }
        }
	    else
	    {
	        if (!CanPress)
	        {
	            timer += Time.deltaTime;
	            if (timer >= max_time)
	            {
	                input.text = "";
	                CanPress = true;
	            }
	        }
	        if (input.text.Equals("4321"))
	        {
	            input.text = "Correct!";
	            firstInputIsCorrect = true;
	        }
        }
	    
	}
}
