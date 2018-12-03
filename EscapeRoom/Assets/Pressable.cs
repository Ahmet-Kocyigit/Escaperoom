using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("The switch has loaded");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		print(gameObject.name + " COLLISION DETECTED");
	}
}
