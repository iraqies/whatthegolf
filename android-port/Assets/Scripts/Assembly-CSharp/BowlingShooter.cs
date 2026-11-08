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

	public float SwingRadius;

	public float SwingSpeed;

	public Rigidbody BowlingBallPrefab;

	public float SwingDistance;

	public float ExtraHoldLength;

	public float ThrowSpeedBoost;

	public float BlockTime;

	public bool RagdollAfterFirstShot;

	public GolfCoursePinGoal PinGoal;

	public bool WinWhenAllPinsAreKnockedOver;

	public bool UseCustomWinText;

	public List<Rigidbody> Pins;

	public int PinsLeftToStillWin;

	public float TippedOverThreshold;

	public Collider ColliderUp;

	public float TimeBetweenEvaluation;

	public float EvaluationSplit;

	public bool AlwaysShootInBoostDirection;

	public Vector3 AdditionalShootForce;

	public Transform BallShootPosition;

	public float AppearTime;

	public float Amplitude;

	public Vector3 from;

	public Vector2 DisappearTime;

	public bool isOverwritingWinText;

	public RandomAudioClips swingClips;

	public float sinusThreshold;

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
	}

	private void OnDisable()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}

	private Rigidbody GetNewBowlingBall()
	{
		return null;
	}

	private Vector3 GetBowlingBallPosition()
	{
		return default;
	}

	private void OnAnimatorIK(int layerIndex)
	{
	}

	private Vector3 GetIKPositionAtAngle(float angle)
	{
		return default;
	}

	private void RemovePin(Rigidbody pin)
	{
	}

	public IEnumerator EvaluateShotSplit()
	{
		return null;
	}

	public void EvaluateShot()
	{
	}

	private bool CheckPin(Rigidbody pin)
	{
		return false;
	}

	private void CheckIfWon(int tippedOverPins)
	{
	}
}
