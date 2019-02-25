using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	KeyCode moveForward;
	[SerializeField]
	KeyCode moveBack;
	[SerializeField]
	KeyCode moveRight;
	[SerializeField]
	KeyCode moveLeft;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(moveForward)) {
			transform.position += transform.forward * Time.deltaTime;
		}

		if(Input.GetKey(moveBack)) {
			transform.position -= transform.forward * Time.deltaTime;
		}

		if(Input.GetKey(moveRight)) {
			transform.position += transform.right * Time.deltaTime;
		}

		if(Input.GetKey(moveLeft)) {
			transform.position -= transform.right * Time.deltaTime;
		}
	}
}
