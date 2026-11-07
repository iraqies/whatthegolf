using UnityEngine;

namespace Audio.Conditions
{
	public class VelocityCondition : AudioCondition
	{
		public Rigidbody _Rigidbody;

		public bool overThreshold;

		public float threshold;

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
