﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
	private Material mat;

	// Use this for initialization
	void Start()
	{
		mat = GetComponent<Renderer>().sharedMaterial;
		Physics.IgnoreLayerCollision(9, 9);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.GetComponent<LineRenderer>().sharedMaterial == mat)
			collision.gameObject.layer = 9;
	}
}
