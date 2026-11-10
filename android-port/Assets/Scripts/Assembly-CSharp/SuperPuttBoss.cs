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

		public float TimePerRound = 4f;

		public float GunTowerRotationSpeed = 45f;

		public GameObject GunSettingsObject;
	}

	public RotateAxis GunTower;

	public int Health = 3;

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

	private int currentDirection = 1;

	private float moveSpeedMod = 1f;

	private SuperGolfShooter player;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		timeline = GetComponent<Timeline>();
		player = UnityEngine.Object.FindObjectOfType<SuperGolfShooter>();
	}

	private void Start()
	{
		currentPhase = Mathf.Clamp(StartPhaseIndex, 0, BossPhases != null && BossPhases.Count > 0 ? BossPhases.Count - 1 : 0);
		if (BossPhases != null && BossPhases.Count > 0)
		{
			for (int i = 0; i < BossPhases.Count; i++)
			{
				if (BossPhases[i] != null && BossPhases[i].GunSettingsObject != null)
				{
					BossPhases[i].GunSettingsObject.SetActive(i == currentPhase);
				}
			}
			BossPhase phase = BossPhases[currentPhase];
			if (phase != null && GunTower != null)
			{
				GunTower.speed = phase.GunTowerRotationSpeed;
			}
		}
		SetMovementTarget();
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
		if (BossPhases == null || currentPhase < 0 || currentPhase >= BossPhases.Count)
		{
			return;
		}
		BossPhase phase = BossPhases[currentPhase];
		if (phase == null || phase.Movement == null || phase.Movement.Count < 2)
		{
			return;
		}
		Transform targetTrans = phase.Movement[Mathf.Clamp(currentMovemenTargetIndex, 0, phase.Movement.Count - 1)];
		if (targetTrans == null)
		{
			return;
		}
		float dt = timeline != null ? timeline.fixedDeltaTime : Time.fixedDeltaTime;
		float speed = movementTimerTarget > 0.001f ? (movementDist / movementTimerTarget) * moveSpeedMod : 5f;
		Vector3 curPos = rigid != null ? rigid.position : transform.position;
		Vector3 nextPos = Vector3.MoveTowards(curPos, targetTrans.position, speed * dt);
		if (rigid != null)
		{
			rigid.MovePosition(nextPos);
		}
		else
		{
			transform.position = nextPos;
		}
		if (Vector3.Distance(nextPos, targetTrans.position) < 0.05f)
		{
			SetMovementTarget();
		}
	}

	public void EndPhase()
	{
		StartCoroutine(EndPhaseSequence());
	}

	private IEnumerator EndPhaseSequence()
	{
		if (PhaseEndingParticles != null)
		{
			PhaseEndingParticles.Play();
		}
		if (PhaseEndingClips != null && PhaseEndingClips.Count > 0)
		{
			AudioClip clip = PhaseEndingClips[UnityEngine.Random.Range(0, PhaseEndingClips.Count)];
			if (clip != null)
			{
				AudioManager.PlaySFX(clip, transform.position);
			}
		}
		yield return StartCoroutine(WaitFor(0.5f));
		if (BossPhases != null && currentPhase + 1 < BossPhases.Count)
		{
			NextPhase();
		}
		else
		{
			yield return StartCoroutine(GameWonRoutine());
		}
	}

	private IEnumerator GameWonRoutine()
	{
		OnBossDead?.Invoke();
		if (Core.Level.HasInstance && Core.Level.Instance != null)
		{
			Core.Level.Instance.Complete();
		}
		yield return null;
	}

	private IEnumerator WaitFor(float t)
	{
		float elapsed = 0f;
		while (elapsed < t)
		{
			elapsed += timeline != null ? timeline.deltaTime : Time.deltaTime;
			yield return null;
		}
	}

	private void NextPhase()
	{
		if (BossPhases == null)
		{
			return;
		}
		if (currentPhase >= 0 && currentPhase < BossPhases.Count && BossPhases[currentPhase].GunSettingsObject != null)
		{
			BossPhases[currentPhase].GunSettingsObject.SetActive(false);
		}
		currentPhase++;
		if (currentPhase >= 0 && currentPhase < BossPhases.Count)
		{
			BossPhase phase = BossPhases[currentPhase];
			if (phase.GunSettingsObject != null)
			{
				phase.GunSettingsObject.SetActive(true);
			}
			if (GunTower != null)
			{
				GunTower.speed = phase.GunTowerRotationSpeed;
			}
			currentMovemenTargetIndex = 0;
			currentDirection = 1;
			SetMovementTarget();
		}
	}

	private void SetMovementTarget()
	{
		if (BossPhases == null || currentPhase < 0 || currentPhase >= BossPhases.Count)
		{
			return;
		}
		BossPhase phase = BossPhases[currentPhase];
		if (phase == null || phase.Movement == null || phase.Movement.Count < 2)
		{
			return;
		}
		currentMovemenTargetIndex += currentDirection;
		if (currentMovemenTargetIndex >= phase.Movement.Count)
		{
			if (phase.MovementType == MovementTypeEnum.PingPong)
			{
				currentDirection = -1;
				currentMovemenTargetIndex = phase.Movement.Count - 2;
			}
			else
			{
				currentMovemenTargetIndex = 0;
			}
		}
		else if (currentMovemenTargetIndex < 0)
		{
			currentDirection = 1;
			currentMovemenTargetIndex = 1;
		}
		Transform target = phase.Movement[Mathf.Clamp(currentMovemenTargetIndex, 0, phase.Movement.Count - 1)];
		if (target != null)
		{
			movementDist = Vector3.Distance(transform.position, target.position);
			movementTimerTarget = Mathf.Max(0.2f, phase.TimePerRound / Mathf.Max(1, phase.Movement.Count));
			movementTimer = 0f;
		}
	}

	public void TakeDamage()
	{
		Health--;
		if (Health <= 0)
		{
			StartCoroutine(GameWonRoutine());
		}
		else
		{
			EndPhase();
		}
	}
}
