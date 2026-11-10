using Core;
using UnityEngine;

namespace Arena
{
	public class ArenaCrabShooter : GolfBallShooterBase
	{
		public float continuousMovementMultiplier = 5f;

		public float addForceContinuousMultiplier = 10f;

		public float addForceShootMultiplier = 20f;

		public ForceMode aimUpdateForceMode = ForceMode.Acceleration;

		public ForceMode onShootForceMode = ForceMode.VelocityChange;

		public float fullShootVelocity = 22f;

		public SpiderLegs Legs;

		public Transform Body;

		public bool moveOnAim;

		public Animator AnimatorCrab;

		public Animator AnimatorRider;

		private int shootFrames;

		public bool DidShoot => shootFrames > 0;

		public bool UseAddForce { get; set; }

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (shootFrames > 0)
			{
				shootFrames--;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (moveOnAim && rigidbodyC != null && !onlyAimArrow)
			{
				Vector3 dir = new Vector3(boost.x, 0f, boost.z);
				if (UseAddForce)
				{
					rigidbodyC.AddForce(dir * addForceContinuousMultiplier, aimUpdateForceMode);
				}
				else
				{
					rigidbodyC.velocity = new Vector3(dir.x * continuousMovementMultiplier, rigidbodyC.velocity.y, dir.z * continuousMovementMultiplier);
				}
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			shootFrames = 3;
			if (UseAddForce && rigidbodyC != null)
			{
				rigidbodyC.AddForce(boost * addForceShootMultiplier, onShootForceMode);
			}
			else
			{
				StandardShoot(boost, 15f, 5f, fullShootVelocity > 0f ? fullShootVelocity : 22f, 5f);
			}
		}
	}
}
