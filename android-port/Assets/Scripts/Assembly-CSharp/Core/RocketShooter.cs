using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class RocketShooter : GolfBallShooterBase
	{
		private Rigidbody rb;

		public float minShootVelocity;

		public float fullShootVelocity;

		public float pitch;

		public float spin;

		public ParticleSystem particle;

		private GolfBallController controller;

		public float strokeInterval;

		private bool ignoreFirstCollision;

		private bool wasOverThreshold;

		[SerializeField]
		private Vector3 groundUpDirection;

		[SerializeField]
		private float acceptedGroundedAngle;

		[SerializeField]
		private float acceptedBoostAngle;

		[SerializeField]
		private float collisionKnockoutRelativeVel;

		[SerializeField]
		private ParticleSystem particleSystem;

		[SerializeField]
		private int particleAmount;

		[SerializeField]
		private float knockoutForce;

		[SerializeField]
		private Animation hitAnimation;

		private LayerMask groundLayer;

		private LayerMask playerLayer;

		private Vector3 lastAimDirection;

		[SerializeField]
		private float otherPlayerCountsAsGroundVelocity;

		private Collider lastHit;

		private float nextSameParticles;

		[SerializeField]
		private Material regularMaterial;

		[SerializeField]
		private Material hitMaterial;

		[SerializeField]
		private List<SpriteRenderer> renderers;

		[SerializeField]
		private int hitAnimTimes;

		[SerializeField]
		private float flickerDuration;

		private Coroutine hitAnimCoroutine;

		private void Start()
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		private bool IsGround(Collision collision)
		{
			return false;
		}

		protected override void FixedUpdate()
		{
		}

		private void TriggerCollisionFeedback(Collision other)
		{
		}

		private IEnumerator HitAnimation(int times, float interval)
		{
			return null;
		}
	}
}
