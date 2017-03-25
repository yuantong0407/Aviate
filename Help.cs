﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour {
    public GameObject[] currentThing;
    public GameObject[] otherThing;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //gameObject.GetComponent<Renderer>().material.color = Color.blue;

        foreach (var ob in otherThing)
        {
            ob.SetActive(true);

        }

        foreach (var ob in currentThing)
        {
            ob.SetActive(false);

        }
    }
}
