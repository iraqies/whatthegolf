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
		StandardShoot(boost, 20f, 18f, 5f);
	}
	}
}
