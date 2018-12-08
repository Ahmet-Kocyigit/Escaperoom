using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.VR;

public class SnapController : MonoBehaviour
{
    public GameObject displayscreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ValueController>() != null)
        {
            var text =collision.gameObject.GetComponent<ValueController>().getvalue();
            displayscreen.GetComponent<TextMeshPro>().text = text;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<ValueController>() != null)
        {
            var text = collision.gameObject.GetComponent<ValueController>().getvalue();
            displayscreen.GetComponent<TextMeshPro>().text = text;
        }
    }
}
