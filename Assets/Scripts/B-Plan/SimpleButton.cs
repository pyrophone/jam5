using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleButton : MonoBehaviour {

    [SerializeField] private GameObject bindWall;
	[SerializeField] private int playersNeeded = 1;
	private int curCount;

	// Use this for initialization
	void Start () {
		curCount = 0;
	}

	// Update is called once per frame
	void Update () {

	}

    private void OnPlayerStepOn() {
		curCount++;
		if(curCount > playersNeeded) {
			bindWall.SetActive(false);
			gameObject.SetActive(false);
		}
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            OnPlayerStepOn();
        }
    }

}
