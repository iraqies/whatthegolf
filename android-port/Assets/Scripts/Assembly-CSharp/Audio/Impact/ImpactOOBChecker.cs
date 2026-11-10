using UnityEngine;

namespace Audio.Impact
{
	public class ImpactOOBChecker : ScriptableObject
	{
		public bool CheckCondition(TriggerInfo info, ImpactUser impacter)
		{
			if (info.otherHit == null)
				return false;
			bool isOOB = info.otherHit.CompareTag("OutOfBounds") || info.otherHit.CompareTag("Water") || info.otherHit.CompareTag("Lava");
			if (isOOB && impacter != null)
			{
				impacter.IsEnabled = false;
			}
			return isOOB;
		}
	}
}
