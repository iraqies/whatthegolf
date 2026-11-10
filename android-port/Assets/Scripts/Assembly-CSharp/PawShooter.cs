using System.Collections;
using Core;
using UnityEngine;

public class PawShooter : GolfBallShooterBase
{
	public float pawReach = 5f;

	public float pawKickSpeed = 5f;

	public float upForce;

	public float forwardForce;

	public float pawSpeed = 5f;

	public float resetVelocity = 0.4f;

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
		rb = GetComponent<Rigidbody>();
		basePosition = transform.position;
		baseRotation = transform.rotation;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (rb != null)
			rb.velocity = Vector3.zero;
		if (Rigidbody != null && boost != Vector3.zero)
		{
			Rigidbody.MoveRotation(Quaternion.LookRotation(boost.normalized, Vector3.up));
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private bool Blocked()
	{
		return IsResetCRRunning || isPlacingSpeaker;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (IsResetCRRunning || isPlacingSpeaker)
			return;
		currentBoost = boost;
		ResetCR = StartCoroutine(ResetPosition());
		if (GolfBallController != null)
		{
			GolfBallController.BlockShooting = true;
		}
	}

	private IEnumerator ResetPosition()
	{
		IsResetCRRunning = true;
		if (rb != null)
			rb.isKinematic = true;

		yield return new WaitForFixedUpdate();

		Vector3 kickDir = (currentBoost * forwardForce * 10f + Vector3.up * (boostMagnitude * 10f)).normalized;
		Vector3 startPos = (rb != null) ? rb.position : transform.position;
		Quaternion startRot = (rb != null) ? rb.rotation : transform.rotation;
		Vector3 reachPos = startPos + kickDir * pawReach;

		yield return StartCoroutine(pTween.To(pawKickSpeed, 0f, 1f, t =>
		{
			if (rb != null)
			{
				rb.MovePosition(Vector3.Lerp(startPos, reachPos, Mathf.Clamp01(t)));
			}
		}));

		if (rb != null)
		{
			rb.velocity = Vector3.zero;
			rb.isKinematic = true;
			startPos = rb.position;
			startRot = rb.rotation;
		}

		yield return StartCoroutine(pTween.To(pawSpeed, 0f, 1f, t =>
		{
			if (rb != null)
			{
				rb.MovePosition(Vector3.Lerp(startPos, basePosition, Mathf.Clamp01(t)));
				rb.MoveRotation(Quaternion.Lerp(startRot, baseRotation, t));
			}
		}));

		IsResetCRRunning = false;
	}
}
