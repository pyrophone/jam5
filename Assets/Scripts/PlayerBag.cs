using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBag : MonoBehaviour {

    public int holdAmount;

    public List<Collectable> items;

    [SerializeField] KeyCode useItemKey;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(useItemKey)) {
            UseItem("Coin");
        }
	}

    public void AddToBag(Collectable item) {
        items.Add(item);
        holdAmount++;
    }

    public void UseItem(string name) {
        foreach (Collectable item in items) {
            if (item.itemName == name) {
                items.Remove(item);
                item.OnUse();
                return;
            }
        }

        Debug.Log("Nothing can be used!!!");
        return;
    }

}
