using System;
using System.Collections.Generic;
using System.Linq;
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
		if (string.IsNullOrEmpty(ID))
			return null;

		string[] parts = ID.Split(';');
		string targetId = (parts != null && parts.Length > 0) ? parts[0] : ID;

		var dailyContainer = RuntimeStoreData.DailyPackContainer;
		var specialContainer = RuntimeStoreData.SpecialPackContainer;

		IEnumerable<DailyChallengeLevelDataContainer> allContainers = Enumerable.Empty<DailyChallengeLevelDataContainer>();
		if (dailyContainer != null)
		{
			var dc = dailyContainer.GetContainers();
			if (dc != null)
				allContainers = allContainers.Concat(dc);
		}
		if (specialContainer != null)
		{
			var sc = specialContainer.GetContainers();
			if (sc != null)
				allContainers = allContainers.Concat(sc);
		}

		var specialPrize = allContainers
			.Where(x => x != null)
			.Select(x => x.mountain_prize_prefab)
			.FirstOrDefault(x => x != null && x.prefab != null && x.ID == targetId);

		if (specialPrize != null)
			return specialPrize;

		if (Prizes != null)
		{
			return Prizes.FirstOrDefault(a => a != null && a.ID == targetId);
		}
		return null;
	}

	public Prize GetNextNormalPrize(NormalPrize LastGivenNormalPrize)
	{
		if (Prizes == null || Prizes.Count == 0)
			return null;

		if (LastGivenNormalPrize == null)
			return Prizes.FirstOrDefault();

		int idx = Prizes.IndexOf(LastGivenNormalPrize);
		int nextIdx = idx + 1;
		if (nextIdx >= 0 && nextIdx < Prizes.Count)
			return Prizes[nextIdx];

		return null;
	}
}
