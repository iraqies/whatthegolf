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
			if (info.otherHit == null)
				return false;
			string tag = info.otherHit.tag;
			if (useIncludeTags && (includeTags == null || !includeTags.Contains(tag)))
				return false;
			if (useExcludeTags && excludeTags != null && excludeTags.Contains(tag))
				return false;
			return true;
		}
	}
}
