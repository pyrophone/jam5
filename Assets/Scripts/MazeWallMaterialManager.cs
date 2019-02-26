using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWallMaterialManager : MonoBehaviour {
	public Material[] wallMaterial;

	// Use this for initialization
	void Start () {
		GameObject[] walls = GameObject.FindGameObjectsWithTag("MazeWall");
		foreach(GameObject wall in walls){
			int materialNumber = Random.Range(0,5);
			Debug.Log(materialNumber);
			wall.GetComponent<Renderer>().material = wallMaterial[materialNumber];
		}
	}
}
