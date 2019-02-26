using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public string itemName;
    
    private bool _isCollected;
    private bool _isUsed;
    
	// Use this for initialization
	void Start () {
        _isCollected = false;
        _isUsed = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnUse() {
        _isUsed = true;

        Debug.Log(itemName + " is used!");
    }

    protected virtual void OnCollectBy(GameObject other) {
        _isCollected = true;

        Debug.Log(itemName + " is collect by " + other.name + "!");
        other.GetComponent<PlayerBag>().AddToBag(this);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            OnCollectBy(other.gameObject);
        }
    }

}
