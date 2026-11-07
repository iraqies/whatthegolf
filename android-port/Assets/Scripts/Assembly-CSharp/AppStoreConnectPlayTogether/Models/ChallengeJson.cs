using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AppStoreConnectPlayTogether.Models
{
	public class ChallengeJson
	{
		[CompilerGenerated]
		private string referenceName__BackingField;

		[CompilerGenerated]
		private string vendorIdentifier__BackingField;

		[CompilerGenerated]
		private List<string> allowedAttemptLimits__BackingField;

		[CompilerGenerated]
		private List<string> allowedDurations__BackingField;

		[CompilerGenerated]
		private string leaderboardID__BackingField;

		[CompilerGenerated]
		private string activityIdentifier__BackingField;

		[CompilerGenerated]
		private Uri fallbackURL__BackingField;

		public string referenceName
		{
			[CompilerGenerated]
			set
			{
				referenceName__BackingField = value;
			}
		}

		public string vendorIdentifier
		{
			[CompilerGenerated]
			set
			{
				vendorIdentifier__BackingField = value;
			}
		}

		public List<string> allowedAttemptLimits
		{
			[CompilerGenerated]
			set
			{
				allowedAttemptLimits__BackingField = value;
			}
		}

		public List<string> allowedDurations
		{
			[CompilerGenerated]
			set
			{
				allowedDurations__BackingField = value;
			}
		}

		public string leaderboardID
		{
			[CompilerGenerated]
			set
			{
				leaderboardID__BackingField = value;
			}
		}

		public string activityIdentifier
		{
			[CompilerGenerated]
			set
			{
				activityIdentifier__BackingField = value;
			}
		}

		public Uri fallbackURL
		{
			[CompilerGenerated]
			set
			{
				fallbackURL__BackingField = value;
			}
		}

		public ChallengeJson(string referenceName, string vendorIdentifier, List<string> allowedAttemptLimits, List<string> allowedDurations, string leaderboardID, string activityIdentifier, Uri fallbackURL)
		{
		}
	}
}
