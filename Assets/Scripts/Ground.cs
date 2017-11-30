﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            var tmp = collision.transform.GetComponent<Controller>();
            tmp.isGrounded = true;
            tmp.notGo = true;
            tmp.back = true;
        }
    }
}
