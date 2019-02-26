using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour {
	public GameObject[] players;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Win(){
		GameObject winPlayer = players[0];
		foreach(GameObject player in players){
			Debug.Log(player.GetComponent<PlayerBag>().holdAmount);
			Debug.Log(player.name);
			int holdAmount = player.GetComponent<PlayerBag>().holdAmount;
			int winAmount = winPlayer.GetComponent<PlayerBag>().holdAmount;
			if(holdAmount > winAmount) winPlayer = player;
		}

		winPlayer.GetComponent<PlayerBag>().SetWin();
	}
}
