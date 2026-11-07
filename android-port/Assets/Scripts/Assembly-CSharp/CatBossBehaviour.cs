using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class CatBossBehaviour : MonoBehaviour
{
	[Serializable]
	public class BossEvent
	{
		public string TriggerName;

		public float Weight;

		public int EventsBeforeAvailable;

		public int SkipsLeft;

		public bool HasCustomMovement;

		public AnimationCurve MovementCurve;

		public float NormalizedEventStartPosition;

		public float EventSpeedMod;
	}

	public List<BossEvent> BossEvents;

	public Vector2 LeftRightRanges;

	public Vector2 DelayRange;

	public float MovementSpeedMod;

	public BossIntro Intro;

	public GolfBallController Controller;

	public int Health;

	public ParticleSystem HurtParticles;

	public List<AudioClip> HurtClips;

	public List<GameObject> HurtObjects;

	public List<Rigidbody> Drops;

	public List<AudioClip> SmashClips;

	public List<AudioClip> CatIntroClips;

	public List<AudioClip> CatPeekingClips;

	public List<AudioClip> SwooshClips;

	public List<AudioClip> CatDraggingClips;

	public List<AudioClip> AnticipationClips;

	public AudioClip SmashRecoverClip;

	public AudioClip CatFallClip;

	public AudioClip ExplosionClip;

	public Explosion2D FlagSpawnParticles;

	public GameObject Flag;

	private Animator animator;

	private float delay;

	private float movementTime;

	private float eventTime;

	private BossEvent currentEvent;

	private int direction;

	private int startHealth;

	private static bool hasPlayedIntro;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnReset()
	{
	}

	private void Update()
	{
	}

	public void DoScreenShake()
	{
	}

	private IEnumerator DelayedScreenShake()
	{
		return null;
	}

	private BossEvent GetNextEvent()
	{
		return null;
	}

	private IEnumerator StartEvent()
	{
		return null;
	}

	public void TakeDamage()
	{
	}

	public void PlayPeekClip()
	{
	}

	public void PlayIntro()
	{
	}

	public void PlayDragClip()
	{
	}

	public void PlayFallClip()
	{
	}

	public void PlaySwooshClip()
	{
	}

	public void PlaySmashRecoverClip()
	{
	}

	public void PlayAnticipationClip(int index)
	{
	}
}
