using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    private Transform samImage;
    private Transform obamaImage;
    private Transform liamImage;
    private Transform morganImage;
    private TextMeshPro samText;
    private TextMeshPro obamaText;
    private TextMeshPro liamText;
    private TextMeshPro morganText;
    public bool isActive;

    // Use this for initialization
    void Start ()
    {
        Transform table = GameObject.Find("decorative_table_glass 1").transform;

        samImage = table.GetChild(0);
        samText = samImage.GetChild(0).GetComponent<TextMeshPro>();

        obamaImage = table.GetChild(1);
        obamaText = obamaImage.GetChild(0).GetComponent<TextMeshPro>();

        liamImage = table.GetChild(2);
        liamText = liamImage.GetChild(0).GetComponent<TextMeshPro>();

        morganImage = table.GetChild(3);
        morganText = morganImage.GetChild(0).GetComponent<TextMeshPro>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (isActive)
	    {
	        CalculateDistance(samImage);
            CalculateDistance(obamaImage);
            CalculateDistance(liamImage);
            CalculateDistance(morganImage);
        }
	}

    private void CalculateDistance(Transform otherObject)
    {
        float distance = Vector3.Distance(otherObject.position, transform.position);
        if (distance < 3)
        {
            switch (otherObject.name)
            {
                case "Samuel":
                    samText.text = "SAMUEL";
                    samText.color = Color.magenta;
                    break;
                case "Morgan":
                    morganText.text = "MORGAN";
                    morganText.color = Color.magenta;
                    break;
                case "Liam":
                    liamText.text = "LIAM";
                    liamText.color = Color.magenta;
                    break;
                case "Obama":
                    obamaText.text = "OBAMA";
                    obamaText.color = Color.magenta;
                    break;
                default:
                    return;
            }
        }
        else
        {
            switch (otherObject.name)
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
