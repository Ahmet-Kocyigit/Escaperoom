using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verifyObjectController : MonoBehaviour {


    public GameObject submitter;
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
            var text = collision.gameObject.GetComponent<ValueController>().getvalue();
            submitter.GetComponent<SubmitController>().addAnswer(text);
            print(text);

        }
    }
}
