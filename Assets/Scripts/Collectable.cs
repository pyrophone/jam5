using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    private bool _isCollected;
    
	// Use this for initialization
	void Start () {
        _isCollected = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    protected virtual void OnCollect() {
        _isCollected = true;
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            OnCollect();
        }
    }

}
