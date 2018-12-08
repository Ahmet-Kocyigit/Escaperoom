using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LighController : MonoBehaviour
{

    public string initialColor = "";
    public int emissionindex = 2;

	// Use this for initialization
	void Start () {
        if (!initialColor.Equals(""))
        {
            setColor(initialColor);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setColor(string s)
    {
        var v = gameObject.GetComponent<MeshRenderer>();
        switch (s)
        {
            case "blue":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.blue);
                break;
            case "white":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.white);
                break;
            case "green":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.green);
                break;
            case "yellow":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.yellow);
                break;
            case "red":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.red);
                break;
            case "pink":
                gameObject.GetComponent<MeshRenderer>().materials[emissionindex].SetColor("_EmissionColor", Color.magenta);
                break;
        }

        
    }
}
