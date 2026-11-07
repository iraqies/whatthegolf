using UnityEngine;

namespace Audio.Impact
{
	public abstract class ImpactConditionBase : ScriptableObject
	{
		public bool IsEnabled;

		public abstract bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity);
	}
}
