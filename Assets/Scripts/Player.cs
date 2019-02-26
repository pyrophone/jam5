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

	Rigidbody rb;
	Vector3 moveDir;

	float speed = 10.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		rb.velocity = Vector3.zero;
		moveDir = Vector3.zero;

		if(Input.GetKey(moveForward)) {
			moveDir += Vector3.forward * Time.deltaTime * speed;
		}

		if(Input.GetKey(moveBack)) {
			moveDir -= Vector3.forward * Time.deltaTime * speed;
		}

		if(Input.GetKey(moveRight)) {
			moveDir += Vector3.right * Time.deltaTime * speed;
		}

		if(Input.GetKey(moveLeft)) {
			moveDir -= Vector3.right * Time.deltaTime * speed;
		}

		rb.MovePosition(transform.position + moveDir);
	}
}
