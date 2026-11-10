using System;
using System.Linq;
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

		private DailyChallengeLevelDataContainerContainer Container => RuntimeStoreData.SpecialPackContainer;

		public string SpecialPackName => Special != null ? Special.PackName : null;

		public DailyChallengeLevelDataContainer Special
		{
			get
			{
				if (_special == null && Container != null)
				{
					var containers = Container.GetContainers();
					if (containers != null)
					{
						_special = containers.FirstOrDefault((DailyChallengeLevelDataContainer c) => c != null && c.roomConfig != null && c.roomConfig.Stages != null && c.roomConfig.Stages.Contains(this));
					}
				}
				return _special;
			}
		}

		public string GetCountdownText()
		{
			if (Special == null || Localization.Instance == null)
			{
				return "";
			}
			switch (countdownType)
			{
			case CountdownType.ComingSoon:
				return Localization.Instance.GetString("ID_HUB_SPECIAL_EVENT_COMING_SOON", logFallback: false, null) ?? "";
			case CountdownType.DaysLeft:
			{
				TimeSpan ts = SpecialDayCalendar.TimeUntilSpecialActive(Special);
				if (ts.Days >= 3)
				{
					return Localization.Instance.GetStringWithFormat("ID_HUB_SPECIAL_EVENT_DAYS_LEFT", new object[1] { ts.Days + 1 }) ?? "";
				}
				int hours = (int)ts.TotalHours;
				return Localization.Instance.GetStringWithFormat("ID_HUB_SPECIAL_EVENT_HOURS_LEFT", new object[1] { $"{hours:00}:{ts:mm\\:ss}" }) ?? "";
			}
			case CountdownType.Live:
			{
				if (!DailyChallenges.HasSpecialBeenPlayedBefore())
				{
					return Localization.Instance.GetString("ID_HUB_SPECIAL_EVENT_LIVE", logFallback: false, null) ?? "";
				}
				TimeSpan tsOver = SpecialDayCalendar.TimeUntilSpecialOver(Special);
				if (tsOver.Days >= 3)
				{
					return Localization.Instance.GetStringWithFormat("ID_HUB_SPECIAL_EVENT_ENDS_IN_DAYS", new object[1] { tsOver.Days }) ?? "";
				}
				int hoursLeft = Mathf.Max(0, (int)tsOver.TotalHours);
				return Localization.Instance.GetStringWithFormat("ID_HUB_SPECIAL_EVENT_ENDS_IN_HOURS", new object[1] { $"{hoursLeft:00}:{tsOver:mm\\:ss}" }) ?? "";
			}
			case CountdownType.EventEnded:
				return Localization.Instance.GetString("ID_HUB_SPECIAL_EVENT_ENDED", logFallback: false, null) ?? "";
			default:
				return "";
			}
		}
	}
}
