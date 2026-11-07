using System;
using Core;

namespace BetaAnalytics
{
	public class AnalyticsData
	{
		public float totalTimePlayed;

		public AnalyticsTotalsData totalTotals;

		public void UpdateTotals(Action<AnalyticsTotalsData> updateAction)
		{
		}

		public AnalyticsLevelData CreateLevelData(LevelData level, string challengeId)
		{
			return null;
		}
	}
}
