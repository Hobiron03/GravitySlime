﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetTreasure()
    {
        gameObject.SetActive(true);
        GetComponent<Animator>().SetBool("isGet", true);
    }
}
