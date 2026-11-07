using UnityEngine;

namespace Core
{
	public class RollingCowShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float jumpForce;

		[SerializeField]
		public float dashForce;

		[SerializeField]
		public bool doJumpOnShoot;

		[SerializeField]
		public bool doDashOnShoot;

		[SerializeField]
		public bool onlyPushSpecificTag;

		[SerializeField]
		public string specifiedTag;

		[SerializeField]
		private bool onlyAddTorqueWhenGrounded;

		[SerializeField]
		private LayerMask groundLayer;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool _remoteControlled;

		private Vector3 _remoteControlDirection;

		private bool didAim;

		public float impactForceMultiplier;

		private Collider[] _childColliders;

		private bool grounded;

		private float _lastPush;

		public override void OnActivate()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnCancel()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		protected override void FixedUpdate()
		{
		}

		public void RemoteControl(Vector3 aimDirection)
		{
		}
	}
}
