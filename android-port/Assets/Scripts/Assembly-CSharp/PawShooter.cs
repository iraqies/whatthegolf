using System.Collections;
using Core;
using UnityEngine;

public class PawShooter : GolfBallShooterBase
{
	public float pawReach;

	public float pawKickSpeed;

	public float upForce;

	public float forwardForce;

	public float pawSpeed;

	public float resetVelocity;

	public ParticleSystem interactParticles;

	private float boostMagnitude;

	private Vector3 basePosition;

	private Quaternion baseRotation;

	private Rigidbody rb;

	private Vector3 currentBoost;

	private bool IsResetCRRunning;

	private Coroutine ResetCR;

	internal bool isPlacingSpeaker;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private bool Blocked()
	{
		return false;
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	private IEnumerator ResetPosition()
	{
		return null;
	}
}
