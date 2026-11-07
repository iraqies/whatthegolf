using System;
using System.Collections;
using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class SuperPuttBoss : MonoBehaviour
{
	public enum MovementTypeEnum
	{
		PingPong = 0,
		Loop = 1
	}

	[Serializable]
	public class BossPhase
	{
		public string PhaseName;

		public List<Transform> Movement;

		public MovementTypeEnum MovementType;

		public float TimePerRound;

		public float GunTowerRotationSpeed;

		public GameObject GunSettingsObject;
	}

	public RotateAxis GunTower;

	public int Health;

	public List<BossPhase> BossPhases;

	public ParticleSystem PhaseEndingParticles;

	public List<AudioClip> PhaseEndingClips;

	public List<AudioClip> RoombaLandingClips;

	public int StartPhaseIndex;

	public Action OnBossDead;

	private int currentPhase;

	private float movementTimerTarget;

	private float movementTimer;

	private float movementDist;

	private Timeline timeline;

	private int currentMovemenTargetIndex;

	private Rigidbody rigid;

	private int currentDirection;

	private float moveSpeedMod;

	private SuperGolfShooter player;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void EndPhase()
	{
	}

	private IEnumerator EndPhaseSequence()
	{
		return null;
	}

	private IEnumerator GameWonRoutine()
	{
		return null;
	}

	private IEnumerator WaitFor(float t)
	{
		return null;
	}

	private void NextPhase()
	{
	}

	private void SetMovementTarget()
	{
	}

	public void TakeDamage()
	{
	}
}
