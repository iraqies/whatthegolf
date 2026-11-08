using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class ToyCanonShooter : GolfBallShooterBase
	{
		[SerializeField]
		public Transform controllerShootPosition;

		[SerializeField]
		public ParticleSystem insideCanonParticles;

		[SerializeField]
		public ParticleSystem shootParticles;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[SerializeField]
		public float spin;

		[SerializeField]
		protected bool lookInShotDirection;

		public bool lookInAimDirection;

		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		public float LookInAimDirectionSpeed;

		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[SerializeField]
		protected bool useLocalUp;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		private GolfBallController canonController;

		private Animator canonAnimator;

		private List<Collider> canonColliders;

		private GameObject controllerGO;

		private Rigidbody rigidBodyControllerToShoot;

		private GolfBallController golfBallControllerToShoot;

		protected override void Awake()
		{
		base.Awake();
	}

		private void Start()
		{
		}

		public override void OnActivate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void PutControllerInsideCanon(GameObject controllerInCanon)
		{
		}

		private void EnableControllerInsideTheCanon()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		private IEnumerator DeactivateAllCollidersOnShoot()
		{
			return null;
		}

		private void EnableColliders(bool enable)
		{
		}
	}
}
