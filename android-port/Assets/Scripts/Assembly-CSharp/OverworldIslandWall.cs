using System.Collections.Generic;
using UnityEngine;

public class OverworldIslandWall : MonoBehaviour
{
	public GameObject closedBridgeWall;

	public List<GameObject> openBridgeWall;

	public bool isBridgeWall;

	public void SetBridgeCollider(bool isOpen)
	{
		if (openBridgeWall != null && openBridgeWall.Count >= 1)
		{
			foreach (GameObject item in openBridgeWall)
			{
				if (item != null)
				{
					item.SetActive(isOpen);
				}
			}
		}
		if (closedBridgeWall != null)
		{
			closedBridgeWall.SetActive(!isOpen);
		}
	}
}
