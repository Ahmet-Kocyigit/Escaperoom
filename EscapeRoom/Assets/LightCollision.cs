using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightCollision : MonoBehaviour {
    private TextMeshPro samText;
    private TextMeshPro obamaText;
    private TextMeshPro liamText;
    private TextMeshPro morganText;
    public bool isActive;

    // Use this for initialization
    void Start () {
        samText = GameObject.Find("decorative_table_glass 1").transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
        obamaText = GameObject.Find("decorative_table_glass 1").transform.GetChild(1).GetChild(0).GetComponent<TextMeshPro>();
        liamText = GameObject.Find("decorative_table_glass 1").transform.GetChild(2).GetChild(0).GetComponent<TextMeshPro>();
        morganText = GameObject.Find("decorative_table_glass 1").transform.GetChild(3).GetChild(0).GetComponent<TextMeshPro>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (isActive)
        {
            switch (collision.collider.gameObject.name)
            {
                case "Samuel":
                    samText.text = "3456";
                    samText.color = Color.magenta;
                    break;
                case "Morgan":
                    morganText.text = "2255";
                    morganText.color = Color.magenta;
                    break;
                case "Liam":
                    liamText.text = "3458";
                    liamText.color = Color.magenta;
                    break;
                case "Obama":
                    obamaText.text = "9874";
                    obamaText.color = Color.magenta;
                    break;
                default:
                    return;
            }
        }
        
    }

    void OnCollisionExit(Collision collision)
    {
        if (isActive)
        {
            switch (collision.collider.gameObject.name)
            {
                case "Samuel":
                    samText.text = "";
                    break;
                case "Morgan":
                    morganText.text = "";
                    break;
                case "Liam":
                    liamText.text = "";
                    break;
                case "Obama":
                    obamaText.text = "";
                    break;
                default:
                    return;
            }
        }
       
    }
}
