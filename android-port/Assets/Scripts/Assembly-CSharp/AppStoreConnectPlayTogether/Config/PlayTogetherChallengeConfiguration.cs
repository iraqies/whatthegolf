using System.Collections.Generic;
using UnityEngine;

namespace AppStoreConnectPlayTogether.Config
{
	public class PlayTogetherChallengeConfiguration : ScriptableObject
	{
		public enum EAttemptLimit
		{
			One = 0,
			Three = 1,
			Unlimited = 2
		}

		public enum EDuration
		{
			OneDay = 0,
			OneWeek = 1
		}

		private const string GameActivityVendorIdPrefix = "grp.thelabelgames.golf.challenge";

		private const string FallbackUrlPrefix = "https://static.whatthegolf.com/playtogether";

		[SerializeField]
		private string referenceName;

		[SerializeField]
		private string leaderboardID;

		[SerializeField]
		private string activityIdentifierSuffix;

		[SerializeField]
		private bool allowAttemptLimitOneDay;

		[SerializeField]
		private bool allowAttemptLimitThreeDays;

		[SerializeField]
		private bool allowAttemptLimitUnlimited;

		[SerializeField]
		private bool allowDurationOneDay;

		[SerializeField]
		private bool allowDurationOneWeek;

		[SerializeField]
		private string challengeTitleLocalizationKey;

		[SerializeField]
		private string challengeDescriptionLocalizationKey;

		[SerializeField]
		private List<PlayTogetherChallengeConfigurationLocalizationEntry> challengeLocalizationEntries;

		[SerializeField]
		private LeaderboardBoard previewLeaderboardEnum;

		public string ReferenceName => null;

		public string LeaderboardID => null;

		public string ActivityIdentifier => null;

		public string FallbackURL => null;

		public bool AllowAttemptLimitOneDay => false;

		public bool AllowAttemptLimitThreeDays => false;

		public bool AllowAttemptLimitUnlimited => false;

		public bool AllowDurationOneDay => false;

		public bool AllowDurationOneWeek => false;

		public string ChallengeTitleLocalizationKey => null;

		public string ChallengeDescriptionLocalizationKey => null;

		public IReadOnlyList<PlayTogetherChallengeConfigurationLocalizationEntry> ChallengeLocalizationEntries => null;

		private string PreviewChallengeTitle => null;

		private string PreviewChallengeDescription => null;

		private string PreviewAutoLeaderboardID => null;

		private string PreviewChallengeDeepLink => null;

		public List<EAttemptLimit> GetAllowedAttemptLimitsList()
		{
			return null;
		}

		public List<EDuration> GetAllowedDurationsList()
		{
			return null;
		}

		private static bool ValidateRequiredString(string value)
		{
			return false;
		}

		private static bool ValidateChallengeLocalizationEntries(List<PlayTogetherChallengeConfigurationLocalizationEntry> values)
		{
			return false;
		}
	}
}
