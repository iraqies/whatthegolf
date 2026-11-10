using System;
using System.Linq;
using UnityEngine;

namespace Hub
{
	public class SpecialDayCalendar : ScriptableObject
	{
		[SerializeField]
		private DailyChallengeLevelDataContainer currentSpecial;

		private int _lastDayListSorted;

		private DailyChallengeLevelDataContainerContainer Specials => RuntimeStoreData.SpecialPackContainer;

		public SpecialDayStage GetCurrentStage()
		{
			var specials = Specials;
			if (specials == null) return null;
			var containers = specials.GetContainers();
			if (containers == null || containers.Count == 0) return null;
			var activeSpecial = DailyChallenges.GetSpecialPack();
			if (activeSpecial != null && activeSpecial.roomConfig != null)
			{
				return activeSpecial.roomConfig.LiveStage;
			}
			var cur = GetCurrentSpecial();
			if (cur == null || cur.roomConfig == null) return null;
			DateTime today = DailyChallenges.GetToday();
			if (cur.EndDate < today)
			{
				return cur.roomConfig.PostStage;
			}
			int daysUntil = (cur.StartDate - today).Days;
			var stages = cur.roomConfig.Stages;
			if (stages == null || stages.Count == 0) return null;
			int liveIdx = stages.IndexOf(cur.roomConfig.LiveStage);
			SpecialDayStage fallback = stages[0];
			int accum = 0;
			for (int i = liveIdx - 1; i >= 0; i--)
			{
				var st = stages[i];
				if (st != null)
				{
					accum += st.DurationInDays;
					if (accum >= daysUntil)
					{
						return st;
					}
				}
			}
			return fallback;
		}

		private DailyChallengeLevelDataContainer GetCurrentSpecial()
		{
			var specials = Specials;
			if (specials == null) return currentSpecial;
			var containers = specials.GetContainers();
			if (containers != null && containers.Count > 0)
			{
				currentSpecial = containers.OrderBy((DailyChallengeLevelDataContainer c) => TimeUntilSpecialActive(c)).FirstOrDefault();
			}
			return currentSpecial;
		}

		public static TimeSpan TimeUntilSpecialActive(DailyChallengeLevelDataContainer challengePack)
		{
			if (challengePack == null) return TimeSpan.FromDays(364.0);
			DateTime today = DailyChallenges.GetToday();
			if (today >= challengePack.StartDate)
			{
				int postDays = (challengePack.roomConfig != null && challengePack.roomConfig.PostStage != null) ? challengePack.roomConfig.PostStage.DurationInDays : 0;
				if (today <= challengePack.EndDate.AddDays(postDays))
				{
					return TimeSpan.Zero;
				}
			}
			TimeSpan diff = challengePack.StartDate - today;
			if (diff.TotalSeconds >= 0.0)
			{
				return diff;
			}
			return new TimeSpan(364, 0, 0, 0);
		}

		public static TimeSpan TimeUntilSpecialOver(DailyChallengeLevelDataContainer challengePack)
		{
			if (challengePack == null) return TimeSpan.Zero;
			return challengePack.EndDate - DailyChallenges.GetToday();
		}
	}
}
