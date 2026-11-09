using Core;
using UnityEngine;

namespace GenericShooters
{
	public class GarbageChuteLevelShooter : GolfBallShooterBase
	{
		[SerializeField]
		private float force;

		[SerializeField]
		private float rotationForce;

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}
	}
}
