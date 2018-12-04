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
                gameObject.GetComponent<MeshRenderer>().materials[2].color = Color.blue;
                break;
            case "white":
                gameObject.GetComponent<MeshRenderer>().materials[2].color = Color.white;
                break;
            case "green":
                gameObject.GetComponent<MeshRenderer>().materials[2].color = Color.green;
                break;
        }

        
    }
}
