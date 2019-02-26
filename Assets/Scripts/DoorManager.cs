using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour {
	public GameObject leftDoor;
	public GameObject rightDoor;

	public void OpenDoor(){
		// transform.position += transform.forward * Time.deltaTime * speed;
		leftDoor.transform.position -= transform.right * Time.deltaTime;
		rightDoor.transform.position += transform.right * Time.deltaTime;
		Debug.Log("Inside Door Manager");
	}
}
