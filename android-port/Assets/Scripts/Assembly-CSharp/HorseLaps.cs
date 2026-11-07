using System.Collections.Generic;
using UnityEngine;

public class HorseLaps : MonoBehaviour
{
	public int NumberOfLaps;

	public List<BoxCollider> Waypoints;

	private Dictionary<GameObject, int> lapsLeft;

	private bool horseCompletedTrack;

	private void Awake()
	{
	}

	public bool HorseLap(GameObject horse, bool isPlayer)
	{
		return false;
	}
}
