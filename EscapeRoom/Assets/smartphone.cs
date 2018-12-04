using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smartphone : MonoBehaviour {

    private int max_time = 3;
    private float timer = 0f;
    private bool CanAnswer = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!CanAnswer)
        {
            timer += Time.deltaTime;
            if (timer >= max_time)
            {
                CanAnswer = true;
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (CanAnswer)
        {
            Transform sam = GameObject.Find("smartphone").transform.GetChild(0);
            sam.transform.position.Set(0, 1, 0);
            print("owwyeaah");
        }
    }
}
