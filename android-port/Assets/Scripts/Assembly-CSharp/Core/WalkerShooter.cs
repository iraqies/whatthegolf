using UnityEngine;

namespace Core
{
	public class WalkerShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float maxShootVelocity;

		[SerializeField]
		public float minSteeringTargetDistance;

		[SerializeField]
		public float maxSteeringTargetDistance;

		[SerializeField]
		public AnimationCurve dragCurve;

		[SerializeField]
		public float decayDuration;

		[SerializeField]
		public float dragScale;

		[SerializeField]
		public float maxAngVel;

		private Vector3 target;

		private float shootTime;

		private float startSpeed;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnActivate()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private void OnDrawGizmos()
		{
		}
	}
}
