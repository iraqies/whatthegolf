namespace BetaAnalytics
{
	public class AnalyticsLevelData
	{
		public string id;

		public string levelId;

		public string challengeId;

		public string campaignId;

		public string flagId;

		public string sectionId;

		public bool isOnboarding;

		public int manualRetries;

		public int fails;

		public float lastCompleteTime;

		public int currentStrokes;

		public bool isChallenge => false;
	}
}
