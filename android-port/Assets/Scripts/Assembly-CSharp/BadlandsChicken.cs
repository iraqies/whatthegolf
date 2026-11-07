using System;
using Audio;
using UnityEngine;

public class BadlandsChicken : MonoBehaviour
{
	public ParticleSystem DeathParticles;

	public float OutOfScreenDeathThreshold;

	public Action<BadlandsChicken> OnDeath;

	public RandomAudioClips deathClips;

	private Camera mainCam;

	private bool dead;

	private Rigidbody rigid;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Die()
	{
	}

	public float GetScreenPosX()
	{
		return 0f;
	}

	public Vector3 GetCurrentSpeed()
	{
		return default;
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
