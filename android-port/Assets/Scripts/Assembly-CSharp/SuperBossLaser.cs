using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBossLaser : MonoBehaviour
{
	public SuperPuttBoss CatBoss;

	public Animator Animator;

	public Animator GunAnimator;

	public List<AudioClip> SpawnClips;

	public ParticleSystem SpawnParticles;

	public float AutoUpTime;

	public List<AudioClip> ShootClips;

	private float cooldown;

	private bool playerOnButton;

	private void Awake()
	{
	}

	private void OnBossDead()
	{
	}

	private void Update()
	{
	}

	private void Trigger()
	{
	}

	public IEnumerator SpawnNewGun()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
