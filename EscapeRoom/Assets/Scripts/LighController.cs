using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LighController : MonoBehaviour
{

    public Material white;
    public Material blue;
    public Material green;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setColor(string s)
    {

        switch (s)
        {
            case "blue":
                var comp = gameObject.GetComponent<MeshRenderer>();
                gameObject.GetComponent<MeshRenderer>().materials[2] = blue;
                break;
            case "white":
                gameObject.GetComponent<MeshRenderer>().materials[2] = white;
                break;
            case "green":
                gameObject.GetComponent<MeshRenderer>().materials[2] = green;
                break;
        }

        
    }
}
