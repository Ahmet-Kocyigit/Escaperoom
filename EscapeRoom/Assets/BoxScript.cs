using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public GameObject _boxPartTop;

	// Use this for initialization
	void Start () {
        OpenBox();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OpenBox()
    {
        _boxPartTop.transform.Rotate(0,0,90);
        _boxPartTop.transform.position = new Vector3(-0.5f,0f,0f);
    }
}
