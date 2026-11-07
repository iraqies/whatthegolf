using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DailyPrizeData : ScriptableObject
{
	[Serializable]
	public class Prize
	{
		public GameObject prefab;

		public string ID;
	}

	[Serializable]
	public class NormalPrize : Prize
	{
	}

	public List<NormalPrize> Prizes;

	public NormalPrize LockedMountainPrize;

	public NormalPrize EndPrizeMountain;

	public Prize GetPrize(string ID)
	{
		return null;
	}

	public Prize GetNextNormalPrize(NormalPrize LastGivenNormalPrize)
	{
		return null;
	}
}
