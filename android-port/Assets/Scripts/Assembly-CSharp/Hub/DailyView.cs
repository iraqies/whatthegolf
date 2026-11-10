using System;
using UnityEngine;

namespace Hub
{
	public class DailyView : MonoBehaviour
	{
		[SerializeField]
		private SVGImage image;

		private DailyChallengeLevelDataContainer _pack;

		private DayOfWeek lastUpdate;

		private void Start()
		{
			DateTime today = DailyChallenges.GetToday();
			lastUpdate = today.DayOfWeek;
			_pack = DailyChallenges.GetNormalPack(today);
			Apply(_pack);
		}

		private void Update()
		{
			DateTime today = DailyChallenges.GetToday();
			if (today.DayOfWeek != lastUpdate)
			{
				lastUpdate = today.DayOfWeek;
				_pack = DailyChallenges.GetNormalPack(today);
				Apply(_pack);
			}
		}

		private void Apply(DailyChallengeLevelDataContainer newPack)
		{
			if (newPack != null && image != null)
			{
				image.sprite = newPack.MenuIcon;
			}
		}
	}
}
