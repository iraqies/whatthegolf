using Core;
using UnityEngine;

namespace Arena
{
	public class ArenaCrabShooter : GolfBallShooterBase
	{
		public float continuousMovementMultiplier;

		public float addForceContinuousMultiplier;

		public float addForceShootMultiplier;

		public ForceMode aimUpdateForceMode;

		public ForceMode onShootForceMode;

		public float fullShootVelocity;

		public SpiderLegs Legs;

		public Transform Body;

		public bool moveOnAim;

		public Animator AnimatorCrab;

		public Animator AnimatorRider;

		private int shootFrames;

		public bool DidShoot => false;

		public bool UseAddForce { get; set; }

		protected override void FixedUpdate()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}
	}
}
