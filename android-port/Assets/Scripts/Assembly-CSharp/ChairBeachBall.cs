using Core;
using UnityEngine;

public class ChairBeachBall : MonoBehaviour
{
	public ParticleSystem HitParticles;

	public float pushForce;

	public CrabsController CrabController;

	public PlayerHit playhit;

	private GolfBallController owner;

	private SuperGolfShooter superShooter;

	private Rigidbody rigid;

	private float baseMaxShoot;

	private float nextPushTime;

	private Coroutine shootSpeedRoutine;

	private void Awake()
	{
	}

	public void Push(Vector3 dir)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
