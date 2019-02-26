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

		

		if (collision.gameObject.tag == "WinDoor"){
			Debug.Log("Win");
			WinCondition winCondition = GameObject.FindObjectOfType(typeof(WinCondition)) as WinCondition;
			winCondition.Win();
		}
	}

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.tag == "FinalButton")
        {
            Debug.Log("Hit final button");
            //GameObject.FindObjectOfType(typeof(ScriptA)) as ScriptA
            //DoorManager doorManager = gameObject.GetComponent<DoorManager>();
            DoorManager doorManager = GameObject.FindObjectOfType(typeof(DoorManager)) as DoorManager;
            if (doorManager) doorManager.OpenDoor();
            else Debug.Log("door manager is null");

        }
    }

    Color ColorClamp(Color color){
		for (int i = 0; i < 4; i++)
			if(color[i] > 1) color[i] = 1;

		return color;
	}
}
