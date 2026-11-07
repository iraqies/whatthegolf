using System.Collections;
using Buoyancy;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class SwimmerGolferShooter : GolfBallShooterBase
	{
		[SerializeField]
		private bool extraForceOnFirstSkip;

		[SerializeField]
		private bool onlyAfterFirstShot;

		[SerializeField]
		private float firstSkipExtraYVelocity;

		[SerializeField]
		private float firstSkipExtraXZVelocity;

		[SerializeField]
		private bool customForceOnFirstShot;

		[SerializeField]
		private float firstShotVelocity;

		[SerializeField]
		private float firstShotPitch;

		[SerializeField]
		private float minVelocity;

		[SerializeField]
		private float fullVelocity;

		[SerializeField]
		private float fullPitch;

		[SerializeField]
		private float swimmingPitchMultiplier;

		[SerializeField]
		private float swimmingVelocityMultiplier;

		[SerializeField]
		private float fullSpin;

		[SerializeField]
		private float turnSpeed;

		[SerializeField]
		private Rigidbody GolfClub;

		[SerializeField]
		private Animator golfAnimator;

		[SerializeField]
		private BuoyancyTarget buoyancyTarget;

		[SerializeField]
		private UnityEvent OnCollapse;

		[SerializeField]
		private bool CollapseAtStart;

		[SerializeField]
		private Transform ClubRoot;

		[SerializeField]
		private bool playShootRoutine;

		[SerializeField]
		private bool doFullReset;

		private Rigidbody[] rigidbodies;

		private Rigidbody hips;

		private Rigidbody head;

		private Rigidbody leftFoot;

		private Rigidbody rightFoot;

		private GolfBallController controller;

		private Vector3 lastBoost;

		private bool hasCollapsed;

		private bool isCollapsing;

		private Vector3 oldPosition;

		private Quaternion oldRotation;

		public CBFollow followCamera;

		private Vector3 targetBlend;

		private float velRef;

		private int skipCountAfterShot;

		private int shotCount;

		private Vector3 baseClubLocalPosition;

		private Quaternion baseClubLocalRotation;

		private Transform baseClubParent;

		private Transform baseArrowFollow;

		public float lookDirectionForce;

		public float feetForceMultiplier;

		protected override void Awake()
		{
		}

		private void BuoyancyTarget_OnPostSkip(Vector3 obj)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		protected override void FixedUpdate()
		{
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

		private IEnumerator ShootRoutine(Vector3 boost)
		{
			return null;
		}

		public override void OnReset()
		{
		}

		private Vector3 PitchBoost(Vector3 boost, bool first = false)
		{
			return default;
		}

		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			return null;
		}
	}
}
