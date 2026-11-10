using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using GolfCourse;
using UnityEngine;

public class BowlingShooter : GolfBallShooterBase
{
	public Animator Animator;

	public float SwingRadius = 5f;

	public float SwingSpeed = 5f;

	public Rigidbody BowlingBallPrefab;

	public float SwingDistance = 2f;

	public float ExtraHoldLength = 1f;

	public float ThrowSpeedBoost = 2f;

	public float BlockTime = 0.5f;

	public bool RagdollAfterFirstShot;

	public GolfCoursePinGoal PinGoal;

	public bool WinWhenAllPinsAreKnockedOver = true;

	public bool UseCustomWinText;

	public List<Rigidbody> Pins;

	public int PinsLeftToStillWin;

	public float TippedOverThreshold = 0.8f;

	public Collider ColliderUp;

	public float TimeBetweenEvaluation;

	public float EvaluationSplit = 1f;

	public bool AlwaysShootInBoostDirection;

	public Vector3 AdditionalShootForce;

	public Transform BallShootPosition;

	public float AppearTime = 0.4f;

	public float Amplitude = 1f;

	public Vector3 from = Vector3.one * 1.5f;

	public Vector2 DisappearTime = new Vector2(3.5f, 4.5f);

	public bool isOverwritingWinText = true;

	public RandomAudioClips swingClips;

	public float sinusThreshold = 0.8f;

	public float boostThresholdForSwingSounds;

	public Action<Rigidbody> OnBallShot;

	public Action<GameObject> BallThrown;

	private float lastSin;

	private float swingAngle;

	private float weightTarget;

	private float weight;

	private int numberOfShots;

	private int numberOfPins;

	private Vector3 ballPosition;

	private Vector3 ballVelocity;

	private bool didWin;

	private float evaluateTimer;

	private bool routineRunning;

	public Rigidbody bowlingBall { get; private set; }

	public Vector3 lastBallPosition { get; private set; }

	private void Start()
	{
		bowlingBall = GetNewBowlingBall();
		if (Pins != null)
		{
			Pins.RemoveAll(p => p == null);
			numberOfPins = Pins.Count;
		}
		if (bowlingBall != null)
		{
			ballPosition = bowlingBall.transform.position;
		}
		lastBallPosition = ballPosition;
	}

	private void OnDisable()
	{
		if (bowlingBall != null)
			bowlingBall.gameObject.SetActive(false);
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (bowlingBall == null)
			return;

		bowlingBall.isKinematic = false;
		bowlingBall.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		bowlingBall.velocity = ballVelocity.normalized * ThrowSpeedBoost * boost.magnitude;

		if (AlwaysShootInBoostDirection)
		{
			if (BallShootPosition != null)
				bowlingBall.transform.position = BallShootPosition.position;
			boost += AdditionalShootForce;
			bowlingBall.velocity = boost * ThrowSpeedBoost;
		}
		else if (bowlingBall.velocity.y < 0f || Vector3.Angle(bowlingBall.velocity, boost) < 90f)
		{
			float speed = bowlingBall.velocity.magnitude;
			Vector3 flat = new Vector3(bowlingBall.velocity.x, 0f, bowlingBall.velocity.z).normalized;
			bowlingBall.velocity = flat * speed;
		}

		OnBallShot?.Invoke(bowlingBall);
		BallThrown?.Invoke(bowlingBall.gameObject);
		weightTarget = 0f;
		numberOfShots++;
		if (GolfBallController != null)
			GolfBallController.TimedBlockShot(BlockTime);
		bowlingBall = null;

		if (!RagdollAfterFirstShot)
		{
			StartCoroutine(pTween.To(BlockTime * 0.9f, _ => { }).Then(() => bowlingBall = GetNewBowlingBall()));
		}
	}

	public override void OnAimStart()
	{
		if (bowlingBall == null)
			bowlingBall = GetNewBowlingBall();
		base.OnAimStart();
		swingAngle = 0f;
		weightTarget = 1f;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		if (boost.sqrMagnitude > 1e-6f)
			transform.rotation = Quaternion.LookRotation(boost, transform.up);

		if (!onlyAimArrow)
		{
			swingAngle += Time.deltaTime * boost.magnitude * SwingSpeed;
			if (boost.magnitude > boostThresholdForSwingSounds)
			{
				float sinVal = Mathf.Sin(swingAngle);
				if (lastSin > sinusThreshold && sinVal < sinusThreshold && swingClips != null)
				{
					swingClips.PlayRandomClip(transform.position, boost.magnitude, boost.magnitude);
				}
				lastSin = sinVal;
			}
		}
	}

	private void Update()
	{
		weight = Mathf.MoveTowards(weight, weightTarget, Time.deltaTime * 2f);
		if (bowlingBall != null)
		{
			ballPosition = bowlingBall.transform.position;
			if (Time.deltaTime > 0f)
				ballVelocity = (ballPosition - lastBallPosition) / Time.deltaTime;
			lastBallPosition = ballPosition;
			Vector3 right = transform.right;
			ballVelocity -= right * Vector3.Dot(right, ballVelocity);
			if (bowlingBall.isKinematic)
			{
				bowlingBall.transform.position = GetBowlingBallPosition();
			}
		}

		if (evaluateTimer < TimeBetweenEvaluation)
		{
			evaluateTimer += Time.deltaTime;
		}
		else if (EvaluationSplit < 1f)
		{
			evaluateTimer = 0f;
			if (!routineRunning)
				StartCoroutine(EvaluateShotSplit());
		}
		else
		{
			EvaluateShot();
			evaluateTimer = 0f;
		}
	}

	private Rigidbody GetNewBowlingBall()
	{
		if (BowlingBallPrefab == null)
			return null;

		Rigidbody ball = RagdollAfterFirstShot ? BowlingBallPrefab : Instantiate(BowlingBallPrefab);
		if (ball == null)
			return null;

		ball.gameObject.SetActive(true);
		ball.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
		ball.isKinematic = true;
		ball.transform.position = GetBowlingBallPosition();
		Vector3 targetScale = ball.transform.localScale;
		ball.transform.localScale = Vector3.zero;
		StartCoroutine(pTween.To(AppearTime, t =>
		{
			if (ball != null)
				ball.transform.localScale = Vector3.LerpUnclamped(Vector3.zero, targetScale, TweenFunctions.BackEaseOut(t, Amplitude));
		}));
		return ball;
	}

	private Vector3 GetBowlingBallPosition()
	{
		if (Animator == null)
			return transform.position;
		Transform rightHand = Animator.GetBoneTransform(HumanBodyBones.RightHand);
		Transform rightLowerArm = Animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
		if (rightHand == null || rightLowerArm == null)
			return transform.position;
		Vector3 handPos = rightHand.position;
		Vector3 dir = (handPos - rightLowerArm.position).normalized;
		return handPos + dir * ExtraHoldLength;
	}

	private void OnAnimatorIK(int layerIndex)
	{
		if (layerIndex != 0 || Animator == null)
			return;
		Animator.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
		Animator.SetIKPosition(AvatarIKGoal.RightHand, GetIKPositionAtAngle(swingAngle));
	}

	private Vector3 GetIKPositionAtAngle(float angle)
	{
		if (Animator == null)
			return transform.position;
		Transform rightUpperArm = Animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
		if (rightUpperArm == null)
			return transform.position;
		Vector3 basePos = rightUpperArm.position + transform.right * SwingDistance;
		Vector3 offset = new Vector3(0f, Mathf.Sin(angle) * SwingRadius, Mathf.Cos(angle) * SwingRadius);
		return basePos + transform.TransformVector(offset);
	}

	private void RemovePin(Rigidbody pin)
	{
		if (pin == null)
			return;
		if (Pins != null)
			Pins.Remove(pin);

		AudioTrigger[] triggers = pin.GetComponents<AudioTrigger>();
		if (triggers != null)
		{
			for (int i = 0; i < triggers.Length; i++)
			{
				if (triggers[i] != null)
					Destroy(triggers[i]);
			}
		}

		Vector3 startScale = pin.transform.localScale;
		float waitTime = UnityEngine.Random.Range(DisappearTime.x, DisappearTime.y);
		float shrinkTime = UnityEngine.Random.Range(0.1f, 0.2f);
		StartCoroutine(pTween.To(waitTime, _ => { }).Then(pTween.To(shrinkTime, t =>
		{
			if (pin != null)
				pin.transform.localScale = Vector3.LerpUnclamped(startScale, Vector3.zero, TweenFunctions.BackEaseIn(t, Amplitude));
		}).Then(() =>
		{
			if (pin != null)
				pin.gameObject.SetActive(false);
		})));
	}

	public IEnumerator EvaluateShotSplit()
	{
		routineRunning = true;
		if (!didWin)
		{
			int tippedCount = 0;
			int evaluatedInFrame = 0;
			for (int i = numberOfPins - 1; i >= 0; i--)
			{
				if (Pins != null && i < Pins.Count)
				{
					if (CheckPin(Pins[i]))
						tippedCount++;
				}
				else
				{
					tippedCount++;
				}
				evaluatedInFrame++;
				if (evaluatedInFrame >= EvaluationSplit * numberOfPins)
				{
					evaluatedInFrame = 0;
					yield return null;
				}
			}
			CheckIfWon(tippedCount);
		}
		routineRunning = false;
	}

	public void EvaluateShot()
	{
		if (didWin)
			return;
		int tippedCount = 0;
		for (int i = numberOfPins - 1; i >= 0; i--)
		{
			if (Pins != null && i < Pins.Count)
			{
				if (CheckPin(Pins[i]))
					tippedCount++;
			}
			else
			{
				tippedCount++;
			}
		}
		CheckIfWon(tippedCount);
	}

	private bool CheckPin(Rigidbody pin)
	{
		if (pin == null)
			return true;

		Vector3 upNormal = Vector3.up;
		if (ColliderUp != null)
		{
			Vector3 dir = (ColliderUp.transform.position - pin.transform.position).normalized;
			Ray ray = new Ray(pin.transform.position, dir);
			if (ColliderUp.Raycast(ray, out RaycastHit hit, 100f))
				upNormal = hit.normal;
		}

		float dot = Vector3.Dot(upNormal, pin.transform.up);
		if (dot <= TippedOverThreshold || (ColliderUp == null && pin.transform.position.y < -5f))
		{
			RemovePin(pin);
			return true;
		}
		return false;
	}

	private void CheckIfWon(int tippedOverPins)
	{
		if (Level.Instance == null || !WinWhenAllPinsAreKnockedOver)
			return;
		if (tippedOverPins < numberOfPins - PinsLeftToStillWin)
			return;

		didWin = true;
		if (Level.Instance.IsMultiplayer && PinGoal != null)
		{
			PinGoal.CheckObject(transform, false);
			return;
		}

		if (Level.Instance.Goal == null)
			return;

		if (UseCustomWinText)
		{
			string text = GetCompletionTextBasedOnScore.GetText(numberOfShots);
			if (text != null)
				Level.Instance.Goal.TriggerWin(text);
			else
				Level.Instance.Goal.TriggerWin();
		}
		else
		{
			Level.Instance.Goal.TriggerWin();
		}
	}
}
