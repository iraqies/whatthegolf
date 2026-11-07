using System;
using UnityEngine;

namespace Hub
{
	[Serializable]
	public class SpecialDayStage
	{
		public enum CountdownType
		{
			ComingSoon = 0,
			DaysLeft = 1,
			Live = 2,
			EventEnded = 3
		}

		public bool IsAvailable;

		public GameObject RoomDressing;

		public int DurationInDays;

		[SerializeField]
		private CountdownType countdownType;

		private DailyChallengeLevelDataContainer _special;

		private DailyChallengeLevelDataContainerContainer Container => null;

		public string SpecialPackName => null;

		private DailyChallengeLevelDataContainer Special => null;

		public string GetCountdownText()
		{
			return null;
		}
	}
}
