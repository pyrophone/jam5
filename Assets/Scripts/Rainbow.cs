using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour {

	Renderer ren;
	float timeCounter;

	// Use this for initialization
	void Start () {
		ren = GetComponent<Renderer>();
		timeCounter = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;

		//if(timeCounter >= 360.0f)
		//	timeCounter = 0.0f;
		ren.material.color = new Color(Mathf.Sin(timeCounter), Mathf.Cos(timeCounter), -Mathf.Sin(timeCounter), 1.0f);
	}
}
