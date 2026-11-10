using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class FrisbeeThrower : GolfBallShooterBase
{
	public Animator Animator;

	public float SwingRadius = 1f;

	public float SwingSpeed = 4f;

	public Rigidbody BowlingBallPrefab;

	public float SwingDistance = 1f;

	public float ExtraHoldLength = 0.2f;

	public float ThrowSpeedBoost = 15f;

	public float BlockTime = 0.5f;

	public float SinMod = 1f;

	public float CosMod = 1f;

	public bool RagdollAfterFirstShot;

	public Vector3 Spin;

	public Vector3 Pitch;

	public List<Rigidbody> Pins;

	public int PinsLeftToStillWin = 2;

	public float TippedOverThreshold = 0.5f;

	public Collider ColliderUp;

	public float AppearTime = 0.3f;

	public float Amplitude = 1f;

	public Vector3 from;

	public RandomAudioClips swingClips;

	public float sinusThreshold = 0.8f;

	public float boostThresholdForSwingSounds = 0.2f;

	private float swingAngle;

	private float weightTarget;

	private float weight;

	private float lastSin;

	private int numberOfShots;

	private int numberOfPins;

	private Rigidbody bowlingBall;

	private Vector3 lastBallPosition;

	private Vector3 ballPosition;

	private Vector3 ballVelocity;

	private bool didWin;

	private void Start()
	{
		if (Pins != null)
		{
			numberOfPins = Pins.Count;
		}
		if (BowlingBallPrefab != null)
		{
			bowlingBall = GetNewBowlingBall();
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		weightTarget = 0f;
		numberOfShots++;
		if (bowlingBall == null && BowlingBallPrefab != null)
		{
			bowlingBall = GetNewBowlingBall();
		}
		if (bowlingBall != null)
		{
			bowlingBall.transform.SetParent(null);
			bowlingBall.isKinematic = false;
			Vector3 shotVel = (ballVelocity.sqrMagnitude > 0.01f ? ballVelocity : boost) * ThrowSpeedBoost;
			if (shotVel.sqrMagnitude < 1f)
			{
				shotVel = boost * Mathf.Max(10f, ThrowSpeedBoost);
			}
			bowlingBall.velocity = shotVel;
			bowlingBall.angularVelocity = Spin;
			bowlingBall = null;
		}
		else
		{
			StandardShoot(boost, 15f, 5f, 22f, 5f);
		}
		if (RagdollAfterFirstShot && numberOfShots >= 1)
		{
			ToggleGenericRagdoll ragdoll = GetComponentInChildren<ToggleGenericRagdoll>();
			if (ragdoll != null)
			{
				ragdoll.SetRagdoll(true);
			}
		}
		BlockShootingForSeconds(BlockTime);
	}

	public override void OnAimStart()
	{
		base.OnAimStart();
		weightTarget = 1f;
		if (bowlingBall == null && BowlingBallPrefab != null)
		{
			bowlingBall = GetNewBowlingBall();
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		weightTarget = 1f;
		float mag = boost.magnitude;
		swingAngle += Time.deltaTime * SwingSpeed * Mathf.Max(0.25f, mag);
		float curSin = Mathf.Sin(swingAngle);
		if (mag >= boostThresholdForSwingSounds && lastSin < sinusThreshold && curSin >= sinusThreshold && swingClips != null)
		{
			AudioManager.PlaySFX(swingClips, transform.position);
		}
		lastSin = curSin;
	}

	private void Update()
	{
		weight = Mathf.MoveTowards(weight, weightTarget, Time.deltaTime * 5f);
		lastBallPosition = ballPosition;
		ballPosition = GetBowlingBallPosition();
		if (Time.deltaTime > 0.0001f)
		{
			ballVelocity = (ballPosition - lastBallPosition) / Time.deltaTime;
		}
		if (bowlingBall != null && bowlingBall.isKinematic)
		{
			bowlingBall.transform.position = ballPosition;
		}
		EvaluateShot();
	}

	private Rigidbody GetNewBowlingBall()
	{
		if (BowlingBallPrefab == null)
		{
			return null;
		}
		Vector3 pos = GetBowlingBallPosition();
		Rigidbody inst = Object.Instantiate(BowlingBallPrefab, pos, Quaternion.identity);
		inst.gameObject.SetActive(true);
		inst.isKinematic = true;
		return inst;
	}

	private Vector3 GetBowlingBallPosition()
	{
		return GetIKPositionAtAngle(swingAngle);
	}

	private void OnAnimatorIK(int layerIndex)
	{
		if (Animator == null)
		{
			return;
		}
		Animator.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
		Animator.SetIKPosition(AvatarIKGoal.RightHand, GetIKPositionAtAngle(swingAngle));
	}

	private Vector3 GetIKPositionAtAngle(float angle)
	{
		Vector3 localOffset = new Vector3(
			Mathf.Cos(angle * CosMod) * SwingRadius,
			Mathf.Sin(angle * SinMod) * Amplitude,
			Mathf.Sin(angle * SinMod) * SwingDistance
		);
		return transform.TransformPoint(from + localOffset);
	}

	private void RemovePin(Rigidbody pin)
	{
		if (Pins != null && pin != null)
		{
			Pins.Remove(pin);
		}
	}

	public void EvaluateShot()
	{
		if (didWin || Pins == null || numberOfPins == 0)
		{
			return;
		}
		for (int i = Pins.Count - 1; i >= 0; i--)
		{
			Rigidbody pin = Pins[i];
			if (pin == null || Vector3.Dot(pin.transform.up, Vector3.up) < TippedOverThreshold || pin.transform.position.y < transform.position.y - 2f)
			{
				Pins.RemoveAt(i);
			}
		}
		if (Pins.Count <= PinsLeftToStillWin)
		{
			didWin = true;
			Flag flag = Object.FindObjectOfType<Flag>();
			if (flag != null)
			{
				flag.TouchFlag(true);
			}
		}
	}
}
