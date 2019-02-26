using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBag : MonoBehaviour {

    public int holdAmount;
    [SerializeField] private GameObject _playerDataUI;

    public List<Collectable> items;

    [SerializeField] private KeyCode useItemKey;

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

        SetCoinIndicator(holdAmount);
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

    private void SetCoinIndicator(int amount) {
        _playerDataUI.transform.Find("CoinIndicator").GetComponent<Text>().text = "" + amount;
    }

    public void SetWin(){
        GameObject.Find("Win").GetComponent<Text>().text = name + "\nWins";
    }

}
