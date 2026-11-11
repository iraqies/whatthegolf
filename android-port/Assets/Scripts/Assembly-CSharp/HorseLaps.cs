using System.Collections.Generic;
using Core;
using UnityEngine;

public class HorseLaps : MonoBehaviour
{
	public int NumberOfLaps = 3;

	public List<BoxCollider> Waypoints;

	private Dictionary<GameObject, int> lapsLeft;

	private bool horseCompletedTrack;

	private void Awake()
	{
		lapsLeft = new Dictionary<GameObject, int>();
	}

	public bool HorseLap(GameObject horse, bool isPlayer)
	{
		Debug.Log(((horse != null) ? horse.ToString() : null) + " completed lap");
		if (lapsLeft == null)
		{
			lapsLeft = new Dictionary<GameObject, int>();
		}
		if (!lapsLeft.ContainsKey(horse))
		{
			lapsLeft.Add(horse, 0);
		}
		lapsLeft[horse]++;
		if (lapsLeft[horse] < NumberOfLaps)
		{
			return false;
		}
		if (horseCompletedTrack)
		{
			return true;
		}
		if (Level.Instance != null)
		{
			if (isPlayer)
			{
				if (Level.Instance.Goal != null)
				{
					Level.Instance.Goal.Complete();
				}
			}
			else
			{
				Level.Instance.Fail(true, true, null, 0f, true, "");
			}
		}
		horseCompletedTrack = true;
		return false;
	}
}
