using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tether : MonoBehaviour
{
	[SerializeField]
	KeyCode switchKey;

	private GameObject tetheredTo;
	private LineRenderer lr;
	private Vector3[] pos;
	private GameManager gm;

	void Awake()
	{
		lr = GetComponent<LineRenderer>();
	}

	// Use this for initialization
	void Start()
	{
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
		pos = new Vector3[2];
		lr.positionCount = 2;
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(switchKey)) {
			gm.SwapTethers(gameObject);
		}

		pos[0] = transform.position;
		pos[1] = tetheredTo.transform.position;
		lr.SetPositions(pos);
	}

	public void SetTetheredTo(GameObject go, Material mat)
	{
		tetheredTo = go;
		lr.material = mat;
	}
}
