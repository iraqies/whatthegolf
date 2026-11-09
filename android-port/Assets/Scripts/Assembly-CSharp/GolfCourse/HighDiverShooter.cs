using Buoyancy;
using Core;
using UnityEngine;

namespace GolfCourse
{
	public class HighDiverShooter : ShooterBase
	{
		[SerializeField]
		private float velocityPreDive;

		[SerializeField]
		private float velocityPostDive;

		[SerializeField]
		private float spinPreDive;

		[SerializeField]
		private float spinPostDive;

		[SerializeField]
		private float pitchPreDive;

		[SerializeField]
		private float pitchPostDive;

		[SerializeField]
		private float maxForceTowardTarget;

		[SerializeField]
		private Transform goTowardTargetOnDive;

		[SerializeField]
		private Collider diveTrigger;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[SerializeField]
		private SphereCastGroundCheck groundCheck;

		public bool debugAddTorque;

		private Rigidbody hips;

		private Rigidbody[] rigidbodies;

		private bool didDive;

		private bool isCollapsed;

		private bool hasLeftWater;

		private Vector3 lastboost;

		private float currentMaxVelocity => 0f;

		private float currentSpin => 0f;

		private float currentPitch => 0f;

		private void Awake()
		{
		}

		public bool CanShoot()
		{
			return false;
		}

		public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}
	}
}
