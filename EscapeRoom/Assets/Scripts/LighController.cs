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
                var mat =comp.materials[2];

                mat = blue;
                comp.materials[2] = mat;
                break;
            case "white":
                gameObject.GetComponent<MeshRenderer>().sharedMaterials[2] = white;
                break;
            case "green":
                gameObject.GetComponent<MeshRenderer>().sharedMaterials[2] = green;
                break;
        }

        
    }
}
