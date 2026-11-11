using System;
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

	public float AutoUpTime = 2f;

	public List<AudioClip> ShootClips;

	private float cooldown;

	private bool playerOnButton;

	private void Awake()
	{
		if (CatBoss != null)
		{
			CatBoss.OnBossDead = (Action)Delegate.Combine(CatBoss.OnBossDead, new Action(OnBossDead));
		}
	}

	private void OnBossDead()
	{
		if (GunAnimator != null)
		{
			GunAnimator.SetBool("Activated", false);
		}
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.U))
		{
			Trigger();
		}
	}

	private void Trigger()
	{
		cooldown = AutoUpTime;
		if (Animator != null)
		{
			Animator.SetBool("IsUp", false);
		}
		if (GunAnimator != null)
		{
			GunAnimator.SetBool("Activated", true);
		}
		StartCoroutine(SpawnNewGun());
	}

	public IEnumerator SpawnNewGun()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SpawnClips);
		}
		float timer = 0f;
		while (timer < 2f)
		{
			timer += Time.deltaTime;
			yield return null;
		}
		if (CatBoss != null)
		{
			CatBoss.TakeDamage();
		}
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(ShootClips);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			playerOnButton = true;
			if (cooldown <= 0f)
			{
				Trigger();
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			playerOnButton = false;
		}
	}
}
