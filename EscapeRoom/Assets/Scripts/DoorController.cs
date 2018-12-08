using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public Transform door;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OpenDoor(){
		Transform doorBottom = door.GetChild(0);
		Transform doorTop = door.GetChild(1);
		float yBottom = doorBottom.position.y;
		float yTop = doorTop.position.y;
		yBottom -= 2f;
		yTop += 2f;
	}
}
