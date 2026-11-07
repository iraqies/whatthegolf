using System.Runtime.CompilerServices;

namespace AppStoreConnectPlayTogether.Models
{
	public class ChallengeLocalizationJson
	{
		[CompilerGenerated]
		private string locale__BackingField;

		[CompilerGenerated]
		private string name__BackingField;

		[CompilerGenerated]
		private string details__BackingField;

		public string locale
		{
			[CompilerGenerated]
			set
			{
				locale__BackingField = value;
			}
		}

		public string name
		{
			[CompilerGenerated]
			set
			{
				name__BackingField = value;
			}
		}

		public string details
		{
			[CompilerGenerated]
			set
			{
				details__BackingField = value;
			}
		}

		public ChallengeLocalizationJson(string locale, string name, string details)
		{
		}
	}
}
