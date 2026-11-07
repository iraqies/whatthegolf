using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AppStoreConnectPlayTogether.Models
{
	public class ResourcesFileJson
	{
		[CompilerGenerated]
		private List<GameActivityJson> gameActivities__BackingField;

		[CompilerGenerated]
		private Dictionary<string, List<GameActivityLocalizationJson>> gameActivityLocalizations__BackingField;

		public List<ChallengeJson> challenges { get; set; }

		public Dictionary<string, List<ChallengeLocalizationJson>> challengeLocalizations { get; set; }

		public List<GameActivityJson> gameActivities
		{
			[CompilerGenerated]
			set
			{
				gameActivities__BackingField = value;
			}
		}

		public Dictionary<string, List<GameActivityLocalizationJson>> gameActivityLocalizations
		{
			[CompilerGenerated]
			set
			{
				gameActivityLocalizations__BackingField = value;
			}
		}
	}
}
