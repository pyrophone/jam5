using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	private GameObject[] players;
	[SerializeField]
	private Material[] mats;

	// Use this for initialization
	void Start()
	{
		players[0].GetComponent<Tether>().SetTetheredTo(players[1], mats[0]);
		players[1].GetComponent<Tether>().SetTetheredTo(players[0], mats[0]);
		players[2].GetComponent<Tether>().SetTetheredTo(players[3], mats[5]);
		players[3].GetComponent<Tether>().SetTetheredTo(players[2], mats[5]);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void SwapTethers(GameObject player)
	{
		float closest = 6.0f;
		int tetherNum = -1;
		int thisNum = -1;
		int counter = 0;

		for(int i = 0; i < 4; i++) {
			if(player == players[i]) {
				counter += ((i == 3) ? 4 : i);
				thisNum = i;
				continue;
			}

			float l = Vector3.Distance(player.transform.position, players[i].transform.position);

			if (l < 2.5f && l < closest) {
				closest = l;
				tetherNum = i;
			}
		}

		counter += ((tetherNum == 3) ? 4 : tetherNum);

		if(tetherNum != -1) {
			int[] otherNums = new int[2];
			int otherMatNum = 0;

			player.GetComponent<Tether>().SetTetheredTo(players[tetherNum], mats[counter - 1]);
			players[tetherNum].GetComponent<Tether>().SetTetheredTo(player, mats[counter - 1]);

			int x = 0;

			for(int i = 0; i < 4; i++) {
				players[i].layer = 0;
				if(i == thisNum || i == tetherNum)
					continue;
				otherNums[x] = i;
				otherMatNum += ((i == 3) ? 4 : i);
				x++;
			}

			players[otherNums[0]].GetComponent<Tether>().SetTetheredTo(players[otherNums[1]], mats[otherMatNum - 1]);
			players[otherNums[1]].GetComponent<Tether>().SetTetheredTo(players[otherNums[0]], mats[otherMatNum - 1]);
		}
	}
}
