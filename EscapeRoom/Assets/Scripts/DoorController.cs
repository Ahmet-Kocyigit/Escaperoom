using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public Transform door;
    private Vector3 doorTopOpenPosition;
    private Vector3 doorBottomOpenPosition;


    // Use this for initialization
    void Start () {
        doorTopOpenPosition = new Vector3(-1.963001f, 5f, 0f);
        doorBottomOpenPosition = new Vector3(-0.01258217f, -2f, 0.1972198f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenDoor(){
		Transform doorBottom = door.GetChild(0);
		Transform doorTop = door.GetChild(1);
        doorBottom.position = doorBottomOpenPosition;
        doorTop.position = doorTopOpenPosition;
	}
}
