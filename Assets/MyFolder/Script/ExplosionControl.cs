﻿using UnityEngine;
using System.Collections;

public class ExplosionControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
