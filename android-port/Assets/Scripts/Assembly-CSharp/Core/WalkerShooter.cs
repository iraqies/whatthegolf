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
		base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (maxShootVelocity > 0f ? maxShootVelocity : 22f), 5f);
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
