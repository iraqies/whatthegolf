using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AppStoreConnectPlayTogether.Config
{
	[Token(Token = "0x2001485")]
	public class PlayTogetherChallengeConfiguration : ScriptableObject
	{
		[Token(Token = "0x2001486")]
		public enum EAttemptLimit
		{
			[Token(Token = "0x4007158")]
			One = 0,
			[Token(Token = "0x4007159")]
			Three = 1,
			[Token(Token = "0x400715A")]
			Unlimited = 2
		}

		[Token(Token = "0x2001487")]
		public enum EDuration
		{
			[Token(Token = "0x400715C")]
			OneDay = 0,
			[Token(Token = "0x400715D")]
			OneWeek = 1
		}

		[Token(Token = "0x4007149")]
		private const string GameActivityVendorIdPrefix = "grp.thelabelgames.golf.challenge";

		[Token(Token = "0x400714A")]
		private const string FallbackUrlPrefix = "https://static.whatthegolf.com/playtogether";

		[Token(Token = "0x400714B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string referenceName;

		[Token(Token = "0x400714C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string leaderboardID;

		[Token(Token = "0x400714D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string activityIdentifierSuffix;

		[Token(Token = "0x400714E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool allowAttemptLimitOneDay;

		[Token(Token = "0x400714F")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool allowAttemptLimitThreeDays;

		[Token(Token = "0x4007150")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool allowAttemptLimitUnlimited;

		[Token(Token = "0x4007151")]
		[FieldOffset(Offset = "0x33")]
		[SerializeField]
		private bool allowDurationOneDay;

		[Token(Token = "0x4007152")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool allowDurationOneWeek;

		[Token(Token = "0x4007153")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string challengeTitleLocalizationKey;

		[Token(Token = "0x4007154")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string challengeDescriptionLocalizationKey;

		[Token(Token = "0x4007155")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<PlayTogetherChallengeConfigurationLocalizationEntry> challengeLocalizationEntries;

		[Token(Token = "0x4007156")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LeaderboardBoard previewLeaderboardEnum;

		[Token(Token = "0x17000B07")]
		public string ReferenceName
		{
			[Token(Token = "0x6006093")]
			[Address(RVA = "0x15F52D8", Offset = "0x15F52D8", VA = "0x15F52D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B08")]
		public string LeaderboardID
		{
			[Token(Token = "0x6006094")]
			[Address(RVA = "0x15F52E0", Offset = "0x15F52E0", VA = "0x15F52E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B09")]
		public string ActivityIdentifier
		{
			[Token(Token = "0x6006095")]
			[Address(RVA = "0x15F52E8", Offset = "0x15F52E8", VA = "0x15F52E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0A")]
		public string FallbackURL
		{
			[Token(Token = "0x6006096")]
			[Address(RVA = "0x15F5340", Offset = "0x15F5340", VA = "0x15F5340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B0B")]
		public bool AllowAttemptLimitOneDay
		{
			[Token(Token = "0x6006097")]
			[Address(RVA = "0x15F53D0", Offset = "0x15F53D0", VA = "0x15F53D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000B0C")]
		public bool AllowAttemptLimitThreeDays
		{
			[Token(Token = "0x6006098")]
			[Address(RVA = "0x15F53D8", Offset = "0x15F53D8", VA = "0x15F53D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000B0D")]
		public bool AllowAttemptLimitUnlimited
		{
			[Token(Token = "0x6006099")]
			[Address(RVA = "0x15F53E0", Offset = "0x15F53E0", VA = "0x15F53E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000B0E")]
		public bool AllowDurationOneDay
		{
			[Token(Token = "0x600609A")]
			[Address(RVA = "0x15F53E8", Offset = "0x15F53E8", VA = "0x15F53E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000B0F")]
		public bool AllowDurationOneWeek
		{
			[Token(Token = "0x600609B")]
			[Address(RVA = "0x15F53F0", Offset = "0x15F53F0", VA = "0x15F53F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000B10")]
		public string ChallengeTitleLocalizationKey
		{
			[Token(Token = "0x600609C")]
			[Address(RVA = "0x15F53F8", Offset = "0x15F53F8", VA = "0x15F53F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B11")]
		public string ChallengeDescriptionLocalizationKey
		{
			[Token(Token = "0x600609D")]
			[Address(RVA = "0x15F5400", Offset = "0x15F5400", VA = "0x15F5400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B12")]
		public IReadOnlyList<PlayTogetherChallengeConfigurationLocalizationEntry> ChallengeLocalizationEntries
		{
			[Token(Token = "0x600609E")]
			[Address(RVA = "0x15F5408", Offset = "0x15F5408", VA = "0x15F5408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B13")]
		private string PreviewChallengeTitle
		{
			[Token(Token = "0x600609F")]
			[Address(RVA = "0x15F5410", Offset = "0x15F5410", VA = "0x15F5410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B14")]
		private string PreviewChallengeDescription
		{
			[Token(Token = "0x60060A0")]
			[Address(RVA = "0x15F548C", Offset = "0x15F548C", VA = "0x15F548C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B15")]
		private string PreviewAutoLeaderboardID
		{
			[Token(Token = "0x60060A1")]
			[Address(RVA = "0x15F5508", Offset = "0x15F5508", VA = "0x15F5508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B16")]
		private string PreviewChallengeDeepLink
		{
			[Token(Token = "0x60060A2")]
			[Address(RVA = "0x15F5518", Offset = "0x15F5518", VA = "0x15F5518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x15F55A8", Offset = "0x15F55A8", VA = "0x15F55A8")]
		public List<EAttemptLimit> GetAllowedAttemptLimitsList()
		{
			return null;
		}

		[Token(Token = "0x60060A4")]
		[Address(RVA = "0x15F56A8", Offset = "0x15F56A8", VA = "0x15F56A8")]
		public List<EDuration> GetAllowedDurationsList()
		{
			return null;
		}

		[Token(Token = "0x60060A5")]
		[Address(RVA = "0x15F5780", Offset = "0x15F5780", VA = "0x15F5780")]
		private static bool ValidateRequiredString(string value)
		{
			return default;
		}

		[Token(Token = "0x60060A6")]
		[Address(RVA = "0x15F579C", Offset = "0x15F579C", VA = "0x15F579C")]
		private static bool ValidateChallengeLocalizationEntries(List<PlayTogetherChallengeConfigurationLocalizationEntry> values)
		{
			return default;
		}

		[Token(Token = "0x60060A7")]
		[Address(RVA = "0x15F57EC", Offset = "0x15F57EC", VA = "0x15F57EC")]
		public PlayTogetherChallengeConfiguration()
		{
		}
	}
}
