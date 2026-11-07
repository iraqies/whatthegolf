using System;
using UnityEngine;

namespace Hub
{
	public class SpecialDayCalendar : ScriptableObject
	{
		[SerializeField]
		private DailyChallengeLevelDataContainer currentSpecial;

		private int _lastDayListSorted;

		private DailyChallengeLevelDataContainerContainer Specials => null;

		public SpecialDayStage GetCurrentStage()
		{
			return null;
		}

		private DailyChallengeLevelDataContainer GetCurrentSpecial()
		{
			return null;
		}

		public static TimeSpan TimeUntilSpecialActive(DailyChallengeLevelDataContainer challengePack)
		{
			return default;
		}

		public static TimeSpan TimeUntilSpecialOver(DailyChallengeLevelDataContainer challengePack)
		{
			return default;
		}
	}
}
