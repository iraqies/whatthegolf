using System;

namespace BetaAnalytics
{
	[Serializable]
	public class AnalyticsTotalsData
	{
		public float totalTimeInOverworld;

		public float totalTimeInPlainLevels;

		public float totalTimeInChallenges;

		public int totalShotsInOnboarding;

		public int totalShotsInOverworld;

		public int totalShotsInLevels;

		public int talkingThingsHit;

		public int flagDialogsCancelCount;

		public float firstCrownTime;
	}
}
