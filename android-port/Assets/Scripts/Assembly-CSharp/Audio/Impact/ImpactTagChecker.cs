using System.Collections.Generic;
using UnityEngine;

namespace Audio.Impact
{
	public class ImpactTagChecker : ImpactConditionBase
	{
		[SerializeField]
		private bool useIncludeTags;

		[SerializeField]
		private List<string> includeTags;

		[SerializeField]
		private bool useExcludeTags;

		[SerializeField]
		private List<string> excludeTags;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
