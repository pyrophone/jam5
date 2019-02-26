using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
				
		if (collision.gameObject.tag == "MazeWall") {
			Tether tether = (Tether)GetComponent("Tether");
			Debug.Log("Collision");
			Color wallColor = collision.gameObject.GetComponent<Renderer>().material.color;
			Color playerColor = GetComponent<Renderer>().material.color + tether.GetTetherTo().GetComponent<Renderer>().material.color;

			Debug.Log(wallColor);
			
			playerColor = ColorClamp(playerColor);
			Debug.Log(GetComponent<Renderer>().material.color);
			if (wallColor == playerColor){
				Destroy(collision.gameObject);
			}	
		}
	}

	Color ColorClamp(Color color){
		for (int i = 0; i < 4; i++)
			if(color[i] > 1) color[i] = 1;

		return color;
	}
}
