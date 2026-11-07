using System.Collections.Generic;
using AppStoreConnectPlayTogether.Models;
using UnityEngine;

namespace AppStoreConnectPlayTogether.Config
{
	public class PlayTogetherResourcesConfiguration : ScriptableObject
	{
		[SerializeField]
		private List<PlayTogetherChallengeConfiguration> challengeConfigs;

		public ResourcesFileJson CreateResourcesFile()
		{
			return null;
		}

		private static bool ValidateChallengeConfigs(List<PlayTogetherChallengeConfiguration> values)
		{
			return false;
		}
	}
}
