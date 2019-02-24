using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable {

	// Use this for initialization
	void Start() {
        itemName = "Coin";
	}
	
	// Update is called once per frame
	void Update() {
		
	}

    public override void OnUse() {
        base.OnUse();

        
    }

    protected override void OnCollectBy(GameObject other) {
        base.OnCollectBy(other);

        
    }

}
