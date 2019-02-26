using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleButton : MonoBehaviour {

    [SerializeField] private GameObject bindWall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnPlayerStepOn() {
        bindWall.SetActive(false);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            OnPlayerStepOn();
        }
    }

}
