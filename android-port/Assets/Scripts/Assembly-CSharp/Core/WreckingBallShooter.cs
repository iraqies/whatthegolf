using UnityEngine;

namespace Core
{
	public class WreckingBallShooter : GolfBallShooterBase
	{
		[SerializeField]
		private float AdjustRotationSpeed;

		[SerializeField]
		private float AngleDampenLimit;

		[SerializeField]
		private Transform Extendable;

		[SerializeField]
		private Vector2 ExtendableRange;

		[SerializeField]
		private float ExtendableMoveSpeed;

		private bool isAiming;

		private float rotationStartupTimer;

		private Vector3 currentBoost;

		private Joint joint;

		private Vector3 startJointAnchor;

		protected override void Awake()
		{
		base.Awake();
	}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnCancel()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, 15f, 5f, 22f, 5f);
	}

		private void AdjustRotation(Vector3 dir)
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}
	}
}
