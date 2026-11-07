using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	public Transform[] patrolRoute;

	public ZombieClub[] golfClubs;

	public Rigidbody ball;

	public bool KickTarget;

	public float UpKickForce;

	public float ForwardKickForce;

	public float kickRange;

	public float slowSpeed;

	public float fastSpeed;

	public float reactDistance;

	public float stopDistance;

	public List<AudioClip> sfxKick;

	public float rotateSpeed;

	public bool lookAlongVelocity;

	public float sightRange;

	public float timeBeforeStopChase;

	public float sightAngle;

	public float angleToForwardBeforeMove;

	public float maxGroundAngle;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private bool targetIsTouching;

	private float lastSeenPlayer;

	private Transform golfClubSeat;

	private ZombieClub golfClub;

	private int currentPatrolTarget;

	private Rigidbody ground;

	private bool grounded;

	private void Start()
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void DoKick(Rigidbody other)
	{
	}

	private void Update()
	{
	}

	private bool CanSee(GameObject obj)
	{
		return false;
	}

	public void GraveAwake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void MoveTowards(Vector3 target, float speed)
	{
	}

	private void LookTowards(Vector3 target, float speed)
	{
	}

	private void LookTowards(Quaternion target, float speed)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
