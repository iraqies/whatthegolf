using System.Collections.Generic;
using Core;
using UnityEngine;

public class RopeBoss : MonoBehaviour
{
	public float MoveSpeed;

	public float BobAmount;

	public float BobSpeed;

	public float ShakeMagnitudeMod;

	public List<Transform> Paws;

	public Animator Animator;

	public AudioSource Source;

	public List<AudioClip> StepClips;

	public List<AudioClip> CrashIntoIslandClips;

	public List<AudioClip> IntroSound;

	public BossIntro Intro;

	public float PauseAfterSeconds;

	public float PauseDuration;

	public GolfBallController GolfBall;

	private Rigidbody rigid;

	private float bobTimer;

	private float previousBob;

	private int lastStepIndex;

	private float introStopTimer;

	private bool playerHasShot;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
