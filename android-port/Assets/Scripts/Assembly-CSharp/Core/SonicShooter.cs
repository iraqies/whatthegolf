using System.Collections;
using UnityEngine;

namespace Core
{
	public class SonicShooter : GolfBallShooterBase
	{
		private Rigidbody rb;

		private float groundLevel;

		private bool touchingGround;

		private Vector3 levitatingPos;

		public float levitatingHeight = 10f;

		public float minShootVelocity;

		public float fullShootVelocity;

		public float pitch;

		public float spin;

		private float gravity = -50f;

		private bool canAim = true;

		private float drag;

		private SonicBounce[] bouncers;

		public ParticleSystem particle;

		private LineRenderer line;

		public MeshRenderer ghost;

		private float thickness;

		private GolfBallController controller;

		private float freezeTime = 0.08f;

		private bool frozen;

		public ParticleSystem active;

		private void Start()
		{
			controller = GetComponent<GolfBallController>();
			rb = GetComponent<Rigidbody>();
			Vector3 g = Physics.gravity;
			g.y = gravity;
			Physics.gravity = g;
			if (rb != null)
			{
				drag = rb.drag;
				rb.drag = 0f;
			}
			bouncers = FindObjectsOfType<SonicBounce>();
			line = GetComponent<LineRenderer>();
			if (line != null)
				line.positionCount = 0;
			SphereCollider sc = GetComponent<SphereCollider>();
			if (sc != null)
				thickness = sc.radius * transform.localScale.magnitude * 0.5f;
		}

		public override void OnAimStart()
		{
			if (rb != null)
			{
				levitatingPos = rb.position;
				levitatingPos.y += Mathf.Min(rb.position.y, groundLevel);
				levitatingPos.y += levitatingHeight - rb.position.y;
			}
			if (Level.Instance != null && Level.Instance.Ball != null)
				Level.Instance.Ball.isBlocking = !canAim;
			if (particle != null)
				particle.Play();
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (touchingGround)
				return;
			if (Level.Instance == null || Level.Instance.Ball == null || Level.Instance.Ball.BlockShooting)
				return;

			Time.timeScale = Mathf.Lerp(Time.timeScale, 0.01f, Time.unscaledDeltaTime * 2f);
			if (rb != null)
			{
				rb.useGravity = false;
				rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Mathf.Clamp01(Time.unscaledDeltaTime * 5f));
				rb.MovePosition(Vector3.Lerp(rb.position, levitatingPos, Mathf.Clamp01(Time.unscaledDeltaTime * 5f)));
			}

			Ray ray = new Ray(transform.position, boost);
			if (line != null)
				line.positionCount = 2;
			if (ghost != null)
				ghost.enabled = true;

			Vector3 endPos;
			if (Physics.SphereCast(ray, thickness, out RaycastHit hit, 80f))
			{
				endPos = Vector3.MoveTowards(hit.point, transform.position, thickness * 0.5f);
			}
			else
			{
				endPos = transform.position + boost.normalized * 80f;
			}

			if (ghost != null)
				ghost.transform.position = endPos;
			if (line != null)
			{
				line.SetPosition(0, transform.position);
				line.SetPosition(1, endPos);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			if (line != null)
				line.positionCount = 0;
			if (ghost != null)
				ghost.enabled = false;
			if (rb != null)
			{
				rb.MovePosition(levitatingPos);
				rb.drag = 0f;
			}
			StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
			if (Level.Instance != null && Level.Instance.Ball != null)
				Level.Instance.Ball.isBlocking = true;
			canAim = false;
			if (active != null)
				active.Stop();
		}

		private void OnCollisionEnter(Collision other)
		{
			if (frozen || other == null || other.collider == null)
				return;

			if (other.collider.CompareTag("Bouncer"))
			{
				if (rb != null && other.contacts != null && other.contacts.Length > 0)
				{
					Vector3 reflDir = Vector3.Reflect(rb.velocity, other.contacts[0].normal).normalized;
					float mag = Mathf.Clamp(rb.velocity.magnitude, minShootVelocity, fullShootVelocity);
					rb.velocity = Vector3.zero;
					float contactY = other.contacts[0].point.y;
					StartCoroutine(FreezeAndShoot(reflDir * mag, contactY));
				}
			}
			else if (!other.collider.CompareTag("Obstacle") && other.contacts != null && other.contacts.Length > 0)
			{
				Chill(other.contacts[0].point);
			}

			if (active != null)
				active.Play();
		}

		private void Chill(Vector3 point)
		{
			if (bouncers != null)
			{
				for (int i = 0; i < bouncers.Length; i++)
				{
					if (bouncers[i] != null)
						bouncers[i].Reset();
				}
			}
			groundLevel = point.y;
			touchingGround = true;
			canAim = true;
		}

		private IEnumerator FreezeAndShoot(Vector3 outVel, float newHigh)
		{
			frozen = true;
			float endTime = Time.time + freezeTime;
			Time.timeScale = 0.1f;
			while (Time.unscaledTime < endTime)
			{
				yield return new WaitForFixedUpdate();
				if (rb != null)
					rb.velocity = Vector3.zero;
			}
			if (rb != null)
				rb.velocity = outVel;
			groundLevel = newHigh;
			canAim = true;
			frozen = false;
		}

		private void OnCollisionExit(Collision other)
		{
			if (other != null && other.collider != null && other.collider.CompareTag("Ground"))
			{
				if (Level.Instance != null && !Level.Instance.IsAiming)
					touchingGround = false;
			}
		}

		private void OnCollisionStay(Collision other)
		{
			if (other != null && other.collider != null && other.collider.CompareTag("Ground"))
			{
				touchingGround = true;
				if (rb != null && rb.velocity.magnitude < 0.1f && controller != null)
				{
					controller.CheckpointHit(transform.position, transform.rotation);
				}
			}
		}

		protected override void FixedUpdate()
		{
			if (Level.Instance != null && (!Level.Instance.IsAiming || !canAim))
			{
				Time.timeScale = Mathf.Lerp(Time.timeScale, 1f, Time.fixedUnscaledDeltaTime);
				if (rb != null)
				{
					rb.useGravity = true;
					Vector3 g = Physics.gravity;
					Vector3 v = new Vector3(rb.velocity.x - g.x, 0f, rb.velocity.z - g.z);
					float factor = Mathf.Min(1f, v.magnitude);
					rb.drag = Mathf.Lerp(rb.drag, factor * drag, Time.fixedUnscaledDeltaTime * 10f);
				}
				if (line != null)
					line.positionCount = 0;
				if (ghost != null)
					ghost.enabled = false;
			}
		}

		private void OnDestroy()
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			Time.timeScale = 1f;
		}
	}
}
