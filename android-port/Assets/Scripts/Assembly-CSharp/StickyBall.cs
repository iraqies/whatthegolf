using System;
using Core;
using UnityEngine;

[RequireComponent(typeof(GolfBallController))]
public class StickyBall : MonoBehaviour
{
	[Range(0f, 1f)]
	public float Stickiness = 1f;

	public bool UseFixedJoint;

	public ParticleSystem Particles;

	public int ParticlesToEmit = 4;

	public float StickDelay = 0.1f;

	public LayerMask BlacklistLayerMask;

	public Action<Vector3> OnStuck;

	public Action OnUnStuck;

	private GolfBallController ball;

	private Rigidbody2D rigid2D;

	private Rigidbody rigid;

	private bool isStuck;

	private ConstantForce force;

	private ConstantForce2D force2D;

	private Vector3 startForce;

	private FixedJoint currentJoint;

	private FixedJoint2D currentJoint2D;

	private float stickDelay;

	private bool attachedToRigidbody;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		rigid2D = GetComponent<Rigidbody2D>();
		force2D = GetComponent<ConstantForce2D>();
		force = GetComponent<ConstantForce>();
		if (force != null)
		{
			startForce = force.force;
		}
		else if (force2D != null)
		{
			Vector2 f = force2D.force;
			startForce = new Vector3(f.x, f.y, 0f);
		}
	}

	private void Start()
	{
		ball = GetComponent<GolfBallController>();
		if (ball != null)
		{
			ball.OnPreShoot += Ball_OnPreShoot;
		}
	}

	private void Ball_OnPreShoot(Vector3 obj)
	{
		Unstuck();
		if (currentJoint != null)
		{
			UnityEngine.Object.Destroy(currentJoint);
		}
		else if (currentJoint2D != null)
		{
			UnityEngine.Object.Destroy(currentJoint2D);
		}
		stickDelay = StickDelay;
	}

	private void FixedUpdate()
	{
		if (isStuck && UseFixedJoint && attachedToRigidbody)
		{
			if (currentJoint != null && currentJoint.connectedBody == null)
			{
				UnityEngine.Object.Destroy(currentJoint);
				Unstuck();
			}
			else if (currentJoint2D != null && currentJoint2D.connectedBody == null)
			{
				UnityEngine.Object.Destroy(currentJoint2D);
				Unstuck();
			}
		}

		if (isStuck)
		{
			if (force != null)
			{
				force.force = startForce * (1f - Stickiness);
			}
			else if (force2D != null)
			{
				float mult = 1f - Stickiness;
				force2D.force = new Vector2(startForce.x * mult, startForce.y * mult);
			}
			if (ball != null)
			{
				ball.BlockShooting = false;
			}
		}
		else
		{
			if (force != null)
			{
				force.force = startForce;
			}
			else if (force2D != null)
			{
				force2D.force = new Vector2(startForce.x, startForce.y);
			}
			if (ball != null)
			{
				ball.BlockShooting = true;
			}
		}
	}

	private void Unstuck()
	{
		isStuck = false;
		attachedToRigidbody = false;
		OnUnStuck?.Invoke();
	}

	private void Stuck(Vector3 normal)
	{
		isStuck = true;
		OnStuck?.Invoke(normal);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null)
			return;

		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		if (force != null)
		{
			force.force = startForce * (1f - Stickiness);
		}

		ContactPoint[] contacts = collision.contacts;
		if (contacts != null && contacts.Length > 0)
		{
			Stuck(contacts[0].normal);
		}

		if (UseFixedJoint)
		{
			if (currentJoint != null)
			{
				UnityEngine.Object.Destroy(currentJoint);
			}
			currentJoint = base.gameObject.AddComponent<FixedJoint>();
			if (currentJoint != null)
			{
				currentJoint.connectedBody = collision.rigidbody;
			}
			attachedToRigidbody = (collision.rigidbody != null);
		}

		if (Particles != null && contacts != null && contacts.Length > 0)
		{
			Particles.transform.rotation = Quaternion.LookRotation(contacts[0].normal, Vector3.up);
			Particles.Emit(ParticlesToEmit);
		}
	}

	private void OnCollisionStay(Collision other)
	{
		if (stickDelay > 0f)
		{
			stickDelay -= Time.deltaTime;
		}
		else if (!isStuck)
		{
			OnCollisionEnter(other);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.gameObject == null)
			return;

		int mask = BlacklistLayerMask;
		if (mask == (mask | (1 << collision.gameObject.layer)))
			return;

		if (rigid2D != null)
		{
			rigid2D.velocity = Vector2.zero;
			rigid2D.angularVelocity = 0f;
		}
		if (force2D != null)
		{
			float mult = 1f - Stickiness;
			force2D.force = new Vector2(startForce.x * mult, startForce.y * mult);
		}

		ContactPoint2D[] contacts = collision.contacts;
		if (contacts != null && contacts.Length > 0)
		{
			Vector2 n = contacts[0].normal;
			Stuck(new Vector3(n.x, n.y, 0f));
		}

		if (UseFixedJoint)
		{
			if (currentJoint2D != null)
			{
				UnityEngine.Object.Destroy(currentJoint2D);
			}
			currentJoint2D = base.gameObject.AddComponent<FixedJoint2D>();
			if (currentJoint2D != null)
			{
				currentJoint2D.connectedBody = collision.rigidbody;
			}
			attachedToRigidbody = (collision.rigidbody != null);
		}

		if (Particles != null && contacts != null && contacts.Length > 0)
		{
			Vector2 n = contacts[0].normal;
			Particles.transform.rotation = Quaternion.LookRotation(new Vector3(n.x, n.y, 0f), Vector3.up);
			Particles.Emit(ParticlesToEmit);
		}
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		if (stickDelay > 0f)
		{
			stickDelay -= Time.deltaTime;
		}
		else if (!isStuck)
		{
			OnCollisionEnter2D(other);
		}
	}
}
