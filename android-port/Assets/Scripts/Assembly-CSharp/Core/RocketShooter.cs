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

		public float strokeInterval = 1f;

		private bool ignoreFirstCollision = true;

		private bool wasOverThreshold;

		[SerializeField]
		private Vector3 groundUpDirection = Vector3.up;

		[SerializeField]
		private float acceptedGroundedAngle = 60f;

		[SerializeField]
		private float acceptedBoostAngle = 60f;

		[SerializeField]
		private float collisionKnockoutRelativeVel = 17f;

		[SerializeField]
		private ParticleSystem particleSystem;

		[SerializeField]
		private int particleAmount;

		[SerializeField]
		private float knockoutForce = 10f;

		[SerializeField]
		private Animation hitAnimation;

		private LayerMask groundLayer;

		private LayerMask playerLayer;

		private Vector3 lastAimDirection;

		[SerializeField]
		private float otherPlayerCountsAsGroundVelocity = 0.1f;

		private Collider lastHit;

		private float nextSameParticles;

		[SerializeField]
		private Material regularMaterial;

		[SerializeField]
		private Material hitMaterial;

		[SerializeField]
		private List<SpriteRenderer> renderers;

		[SerializeField]
		private int hitAnimTimes = 1;

		[SerializeField]
		private float flickerDuration = 0.1f;

		private Coroutine hitAnimCoroutine;

		private void Start()
		{
			controller = GetComponent<GolfBallController>();
			rb = GetComponent<Rigidbody>();
			groundLayer = LayerMask.NameToLayer("Ground");
			playerLayer = LayerMask.NameToLayer("GolfBall");
		}

		public override void OnAimStart()
		{
			if (particle != null)
				particle.Play();
			wasOverThreshold = false;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null)
				return;

			if (!onlyAimArrow && !GolfBallController.BlockShooting)
			{
				boost.Normalize();
				lastAimDirection = boost;
				transform.forward = boost.normalized;
				Vector3 vel = boost * fullShootVelocity;
				if (rb != null)
					rb.velocity = vel;
				if (!wasOverThreshold)
				{
					GolfBallController.CountShot();
					wasOverThreshold = true;
				}
			}
			else
			{
				lastAimDirection = Vector3.zero;
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			if (controller != null)
				controller.StopAiming();
			if (particle != null)
				particle.Stop();
			StandardShoot(Vector3.zero, 0f, 0f, 0f, 0f);
			if (controller != null)
				controller.isBlocking = true;
		}

		private void OnCollisionEnter(Collision other)
		{
			if (ignoreFirstCollision)
			{
				ignoreFirstCollision = false;
				return;
			}
			if (other == null || other.gameObject == null)
				return;

			if (other.gameObject.layer == (int)playerLayer && other.contacts != null && other.contacts.Length > 0)
			{
				Vector3 toHit = (other.contacts[0].point - transform.position).normalized;
				Vector3 myVel = (rb != null) ? rb.velocity : Vector3.zero;
				Rigidbody otherRb = (other.collider != null) ? other.collider.attachedRigidbody : null;
				if (otherRb != null)
				{
					Vector3 fromOther = (other.contacts[0].point - otherRb.transform.position).normalized;
					float myDot = Vector3.Dot(toHit, myVel);
					float otherDot = Vector3.Dot(fromOther, otherRb.velocity);
					if (myDot > otherDot)
						return;
				}
			}

			if (particle != null)
				particle.Stop();
			if (controller != null)
			{
				controller.StopAiming();
				controller.isBlocking = true;
			}

			if (IsGround(other) && other.gameObject.layer != (int)playerLayer)
				return;

			if (rb != null && other.contacts != null && other.contacts.Length > 0)
			{
				rb.AddForce(other.contacts[0].normal * knockoutForce, ForceMode.Impulse);
			}
			TriggerCollisionFeedback(other);

			if (hitAnimCoroutine != null)
			{
				StopCoroutine(hitAnimCoroutine);
				hitAnimCoroutine = null;
				if (renderers != null)
				{
					foreach (SpriteRenderer sr in renderers)
					{
						if (sr != null && regularMaterial != null)
							sr.material = regularMaterial;
					}
				}
			}
			hitAnimCoroutine = StartCoroutine(HitAnimation(hitAnimTimes, flickerDuration));
		}

		private void OnCollisionStay(Collision other)
		{
			if (controller == null || !controller.BlockShooting || other == null)
				return;

			if (IsGround(other))
			{
				controller.isBlocking = false;
				return;
			}
			if (other.gameObject != null && other.gameObject.layer == (int)playerLayer)
			{
				Vector3 toOther = other.transform.position - transform.position;
				if (Vector3.Angle(-groundUpDirection, toOther) < acceptedBoostAngle)
				{
					controller.isBlocking = false;
				}
			}
		}

		private bool IsGround(Collision collision)
		{
			if (collision == null || collision.contacts == null || collision.contacts.Length == 0)
				return false;

			float angle = Vector3.Angle(collision.contacts[0].normal, groundUpDirection);
			if (collision.gameObject != null && collision.gameObject.layer == (int)groundLayer && angle < acceptedGroundedAngle)
				return true;

			if (collision.gameObject != null && collision.gameObject.layer == (int)playerLayer)
			{
				Rigidbody otherRb = (collision.collider != null) ? collision.collider.attachedRigidbody : null;
				if (otherRb != null)
					return otherRb.velocity.magnitude < otherPlayerCountsAsGroundVelocity;
			}
			return false;
		}

		protected override void FixedUpdate()
		{
		}

		private void TriggerCollisionFeedback(Collision other)
		{
			if (other == null)
				return;

			int count = Mathf.RoundToInt(Mathf.Clamp(other.relativeVelocity.magnitude * particleAmount, 0f, 10f));
			Rigidbody otherRb = (other.collider != null) ? other.collider.attachedRigidbody : null;
			if (otherRb != null && !otherRb.isKinematic)
				count /= 2;

			if (particleSystem != null && other.contacts != null && other.contacts.Length > 0)
			{
				particleSystem.transform.position = other.contacts[0].point;
				if (other.collider != lastHit || Time.time >= nextSameParticles)
				{
					particleSystem.Emit(count);
				}
			}
			lastHit = other.collider;
			nextSameParticles = Time.time + 0.1f;
		}

		private IEnumerator HitAnimation(int times, float interval)
		{
			int count = 0;
			float nextFlip = 0f;
			bool useHit = true;
			while (count < times)
			{
				if (Time.time > nextFlip)
				{
					if (renderers != null)
					{
						foreach (SpriteRenderer sr in renderers)
						{
							if (sr != null)
								sr.material = useHit ? hitMaterial : regularMaterial;
						}
					}
					useHit = !useHit;
					nextFlip = Time.time + interval;
					if (useHit)
						count++;
				}
				yield return null;
			}
		}
	}
}
