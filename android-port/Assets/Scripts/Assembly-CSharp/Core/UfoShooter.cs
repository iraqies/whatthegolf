using UnityEngine;

namespace Core
{
	public class UfoShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float targetHeight = 4.2f;

		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[SerializeField]
		private float AdjustRotationSpeed;

		[SerializeField]
		private LayerMask collisionBlackListLayer;

		[SerializeField]
		private bool useGravity = true;

		[SerializeField]
		private Transform upOverride;

		private GolfBallController controller;

		public GolfBallController ballController;

		private ExplosionBarrel barrel;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool didAim;

		private float firstAimTime;

		private float warmup;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		private void OnEnable()
		{
			barrel = GetComponent<ExplosionBarrel>();
			controller = GetComponent<GolfBallController>();
			if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (!onlyAimArrow)
			{
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
				lastShootVelocity = boost.normalized * speed;
				isAiming = true;
			}
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			if (rigidbodyC != null)
				rigidbodyC.useGravity = false;
			if (!didAim)
				firstAimTime = Time.time;
			didAim = true;
			warmup = 0f;
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
			if (rigidbodyC != null)
				rigidbodyC.useGravity = useGravity;
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
			if (dir.sqrMagnitude <= 1e-6f || rigidbodyC == null)
				return;
			float rotSpeed = isDriving ? AdjustRotationSpeedWhileDriving : AdjustRotationSpeed;
			Quaternion targetRot = Quaternion.LookRotation(dir.normalized);
			rigidbodyC.MoveRotation(Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, rotSpeed * Time.unscaledDeltaTime));
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (rigidbodyC != null)
			{
				rigidbodyC.angularVelocity = Vector3.zero;
				rigidbodyC.useGravity = useGravity;
			}
			isAiming = false;
			didAim = true;
		}

		protected override void FixedUpdate()
		{
			if (!didAim)
			{
				if (rigidbodyC != null)
				{
					rigidbodyC.velocity = Vector3.zero;
					rigidbodyC.angularVelocity = Vector3.zero;
				}
				return;
			}

			if (isAiming && rigidbodyC != null)
			{
				if (useGravity)
				{
					Vector3 pos = rigidbodyC.position;
					pos.y = Mathf.MoveTowards(pos.y, targetHeight, Time.fixedDeltaTime * 10f);
					rigidbodyC.position = pos;
				}
				else if (upOverride != null)
				{
					Vector3 targetPos = (rigidbodyC.position - upOverride.position).normalized * targetHeight;
					rigidbodyC.position = Vector3.MoveTowards(rigidbodyC.position, targetPos, Time.fixedDeltaTime * 50f);
				}

				AdjustRotation(lastShootVelocity.normalized, true);
				rigidbodyC.velocity = lastShootVelocity * warmup;
				warmup = Mathf.MoveTowards(warmup, 1f, Time.fixedDeltaTime * 2f);
			}
		}
	}
}
