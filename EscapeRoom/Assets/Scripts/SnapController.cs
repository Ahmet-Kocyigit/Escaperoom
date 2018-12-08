using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Valve.VR;

public class SnapController : MonoBehaviour
{
    public GameObject displayscreen;
    public bool isEnabled =false;
    public GameObject light1;

    // Use this for initialization
    void Start () {

        displayscreen.GetComponent<TextMeshPro>().text = "no power";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void enable()
    {

        light1.GetComponent<LighController>().setColor("green");
        displayscreen.GetComponent<TextMeshPro>().text = "please scan objects";
        this.isEnabled = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isEnabled)
        {
            return;
        }

        if (collision.gameObject.GetComponent<ValueController>() != null)
        {
            var text =collision.gameObject.GetComponent<ValueController>().getvalue();
            displayscreen.GetComponent<TextMeshPro>().text = text;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!isEnabled)
        {
            return;
        }

        if (collision.gameObject.GetComponent<ValueController>() != null)
        {
            var text = collision.gameObject.GetComponent<ValueController>().getvalue();
            displayscreen.GetComponent<TextMeshPro>().text = text;
        }
    }
}
