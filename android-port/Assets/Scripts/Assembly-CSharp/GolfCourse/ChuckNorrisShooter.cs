using System.Collections;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace GolfCourse
{
	public class ChuckNorrisShooter : GolfBallShooterBase
	{
		[SerializeField]
		private float minVelocity;

		[SerializeField]
		private float fullVelocity;

		[SerializeField]
		private float fullPitch;

		[SerializeField]
		private float fullSpin;

		[SerializeField]
		private Rigidbody GolfClub;

		[SerializeField]
		private Animator golfAnimator;

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

		[SerializeField]
		private Rigidbody rigidToShoot;

		[SerializeField]
		private float force;

		private Rigidbody[] rigidbodies;

		private Rigidbody hips;

		private bool hasCollapsed;

		private bool isCollapsing;

		private Vector3 oldPosition;

		private Quaternion oldRotation;

		public CBFollow followCamera;

		private Vector3 targetBlend;

		private float velRef;

		private Vector3 baseClubLocalPosition;

		private Quaternion baseClubLocalRotation;

		private Transform baseClubParent;

		private Transform baseArrowFollow;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
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

		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		private IEnumerator PlayShootSequence(Vector3 boost)
		{
			return null;
		}
	}
}
