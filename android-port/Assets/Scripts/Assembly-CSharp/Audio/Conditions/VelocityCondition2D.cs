using UnityEngine;

namespace Audio.Conditions
{
	public class VelocityCondition2D : AudioCondition
	{
		public Rigidbody2D _Rigidbody;

		public bool overThreshold;

		public float threshold;

		public override bool CheckCondition()
		{
			return false;
		}
	}
}
