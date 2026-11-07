using System.Collections.Generic;
using Audio;
using UnityEngine;

namespace Core
{
	public class HarmonikaDyrShooter : GolfBallShooterBase
	{
		public Rigidbody frontPart;

		public CapsuleCollider frontCapsuleCollider;

		public Rigidbody backPart;

		public CapsuleCollider backCapsuleCollider;

		public Rigidbody midPart;

		public List<Transform> firstSegmentParts;

		public List<Transform> lastSegmentParts;

		public LayerMask groundLayer;

		[SerializeField]
		private float walkSpeed;

		[SerializeField]
		private float retractSpeed;

		public float maxExtendDistance;

		public float minExtendDistance;

		[SerializeField]
		private float raycastDist;

		[SerializeField]
		public List<LaserSentryTarget> laserTargets;

		[SerializeField]
		private RandomAudioClips explodeClips;

		[SerializeField]
		private bool restartOnOutOfBounds;

		public GolfBallController ballController;

		private Vector3 currentBoost;

		private bool isAiming;

		private bool isGrounded;

		private float shotDisableTime;

		private Vector3 lastShootBoost;

		private Joint[] joints;

		private bool hasShot;

		public bool IsRetracting { get; private set; }

		public bool IsPlacing { get; private set; }

		private void OnEnable()
		{
		}

		private void HarmonikaDyrShooter_OnOutOfBounds(OutOfBoundsTrigger obj)
		{
		}

		private void HandleOnLasered()
		{
		}

		private bool isShot()
		{
			return false;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnCancel()
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}

		protected override void FixedUpdate()
		{
		}
	}
}
