using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	public Transform[] patrolRoute;

	public ZombieClub[] golfClubs;

	public Rigidbody ball;

	public bool KickTarget = true;

	public float UpKickForce = 4f;

	public float ForwardKickForce = 6f;

	public float kickRange = 1f;

	public float slowSpeed = 2f;

	public float fastSpeed = 5f;

	public float reactDistance = 15f;

	public float stopDistance = 1f;

	public List<AudioClip> sfxKick;

	public float rotateSpeed = 120f;

	public bool lookAlongVelocity;

	public float sightRange = 12f;

	public float timeBeforeStopChase = 3f;

	public float sightAngle = 60f;

	public float angleToForwardBeforeMove = 30f;

	public float maxGroundAngle = 45f;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private bool targetIsTouching;

	private float lastSeenPlayer = -100f;

	private Transform golfClubSeat;

	private ZombieClub golfClub;

	private int currentPatrolTarget;

	private Rigidbody ground;

	private bool grounded;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		startPosition = transform.position;
		startRotation = transform.rotation;
		lastSeenPlayer = -100f;
	}

	private void OnCollisionStay(Collision collision)
	{
		if (collision == null || collision.contacts == null)
		{
			return;
		}
		for (int i = 0; i < collision.contactCount; i++)
		{
			ContactPoint contact = collision.GetContact(i);
			if (Vector3.Angle(contact.normal, Vector3.up) <= maxGroundAngle)
			{
				grounded = true;
				ground = collision.rigidbody;
				break;
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null)
		{
			return;
		}
		if (ball != null && collision.rigidbody == ball)
		{
			targetIsTouching = true;
			if (KickTarget)
			{
				DoKick(ball);
			}
		}
		OnCollisionStay(collision);
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision != null && ball != null && collision.rigidbody == ball)
		{
			targetIsTouching = false;
		}
	}

	private void DoKick(Rigidbody other)
	{
		if (other == null || Time.time < nextHit)
		{
			return;
		}
		nextHit = Time.time + 0.5f;
		Vector3 dir = (other.position - transform.position);
		dir.y = 0f;
		if (dir.sqrMagnitude > 0.0001f)
		{
			dir.Normalize();
		}
		else
		{
			dir = transform.forward;
		}
		other.AddForce(dir * ForwardKickForce + Vector3.up * UpKickForce, ForceMode.VelocityChange);
		if (sfxKick != null && sfxKick.Count > 0)
		{
			AudioClip clip = sfxKick[Random.Range(0, sfxKick.Count)];
			if (clip != null)
			{
				AudioManager.PlaySFX(clip, transform.position);
			}
		}
	}

	private void Update()
	{
		if (ball != null && KickTarget && (targetIsTouching || Vector3.Distance(transform.position, ball.position) <= kickRange))
		{
			DoKick(ball);
		}
	}

	private bool CanSee(GameObject obj)
	{
		if (obj == null)
		{
			return false;
		}
		Vector3 toObj = obj.transform.position - transform.position;
		float dist = toObj.magnitude;
		if (dist > sightRange)
		{
			return false;
		}
		Vector3 flatToObj = new Vector3(toObj.x, 0f, toObj.z);
		Vector3 flatForward = new Vector3(transform.forward.x, 0f, transform.forward.z);
		if (Vector3.Angle(flatForward, flatToObj) > sightAngle)
		{
			return false;
		}
		if (Physics.Raycast(transform.position + Vector3.up * 0.5f, toObj.normalized, out RaycastHit hit, dist))
		{
			if (hit.collider != null && hit.collider.gameObject != obj && (hit.rigidbody == null || hit.rigidbody.gameObject != obj))
			{
				return false;
			}
		}
		return true;
	}

	public void GraveAwake()
	{
		gameObject.SetActive(true);
		lastSeenPlayer = Time.time;
	}

	private void FixedUpdate()
	{
		if (rigid == null)
		{
			return;
		}
		if (ball != null && CanSee(ball.gameObject))
		{
			lastSeenPlayer = Time.time;
		}
		bool chasing = ball != null && (Time.time - lastSeenPlayer <= timeBeforeStopChase || Vector3.Distance(transform.position, ball.position) <= reactDistance);
		if (chasing)
		{
			if (golfClub != null && golfClubSeat != null)
			{
				golfClub.FreeSeat(golfClubSeat);
				golfClubSeat = null;
				golfClub = null;
			}
			float dist = Vector3.Distance(transform.position, ball.position);
			LookTowards(ball.position, rotateSpeed);
			if (dist > stopDistance)
			{
				MoveTowards(ball.position, fastSpeed);
			}
		}
		else if (patrolRoute != null && patrolRoute.Length > 0)
		{
			Transform target = patrolRoute[currentPatrolTarget % patrolRoute.Length];
			if (target != null)
			{
				LookTowards(target.position, rotateSpeed);
				MoveTowards(target.position, slowSpeed);
				Vector3 flatDiff = target.position - transform.position;
				flatDiff.y = 0f;
				if (flatDiff.magnitude <= Mathf.Max(0.5f, stopDistance))
				{
					currentPatrolTarget = (currentPatrolTarget + 1) % patrolRoute.Length;
				}
			}
		}
		else
		{
			Vector3 flatDiff = startPosition - transform.position;
			flatDiff.y = 0f;
			if (flatDiff.magnitude > 0.5f)
			{
				LookTowards(startPosition, rotateSpeed);
				MoveTowards(startPosition, slowSpeed);
			}
			else
			{
				LookTowards(startRotation, rotateSpeed);
			}
		}
		grounded = false;
	}

	private void MoveTowards(Vector3 target, float speed)
	{
		if (rigid == null)
		{
			return;
		}
		Vector3 diff = target - transform.position;
		diff.y = 0f;
		if (diff.sqrMagnitude < 0.001f)
		{
			return;
		}
		Vector3 dir = diff.normalized;
		Vector3 flatForward = new Vector3(transform.forward.x, 0f, transform.forward.z).normalized;
		if (angleToForwardBeforeMove > 0f && Vector3.Angle(flatForward, dir) > angleToForwardBeforeMove)
		{
			return;
		}
		Vector3 groundVel = ground != null ? ground.velocity : Vector3.zero;
		Vector3 vel = dir * speed;
		vel.y = rigid.velocity.y;
		rigid.velocity = new Vector3(vel.x + groundVel.x, vel.y, vel.z + groundVel.z);
	}

	private void LookTowards(Vector3 target, float speed)
	{
		Vector3 diff = target - transform.position;
		diff.y = 0f;
		if (diff.sqrMagnitude > 0.0001f)
		{
			LookTowards(Quaternion.LookRotation(diff.normalized, Vector3.up), speed);
		}
	}

	private void LookTowards(Quaternion target, float speed)
	{
		Quaternion nextRot = Quaternion.RotateTowards(transform.rotation, target, speed * Time.fixedDeltaTime);
		if (rigid != null)
		{
			rigid.MoveRotation(nextRot);
		}
		else
		{
			transform.rotation = nextRot;
		}
	}

	private void OnDrawGizmos()
	{
	}
}
