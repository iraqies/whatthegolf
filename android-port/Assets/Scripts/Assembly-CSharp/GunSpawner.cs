using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class GunSpawner : MonoBehaviour
{
	public Animator Animator;

	public List<SuperGolfGun> AvailableGuns;

	public Transform SpawnPosition;

	public float ThrowForce = 10f;

	public Vector3 SpawnDirection;

	public List<AudioClip> SpawnClips;

	public ParticleSystem SpawnParticles;

	public float AutoUpTime = 2f;

	private float cooldown;

	private Timeline timeline;

	private bool playerOnButton;

	private void Awake()
	{
		timeline = GetComponent<Timeline>();
	}

	private void Update()
	{
		if (!(cooldown > 0f))
		{
			return;
		}
		float num = ((timeline != null) ? timeline.deltaTime : Time.deltaTime) * Time.timeScale;
		cooldown -= num;
		if (!(cooldown <= 0f))
		{
			return;
		}
		if (Animator != null)
		{
			Animator.SetBool("IsUp", true);
		}
		if (playerOnButton)
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
		SpawnNewGun();
	}

	public void SpawnNewGun()
	{
		if (AvailableGuns != null && AvailableGuns.Count >= 1 && SpawnPosition != null)
		{
			int index = Random.Range(0, AvailableGuns.Count);
			SuperGolfGun superGolfGun = Object.Instantiate(AvailableGuns[index], SpawnPosition.position, Quaternion.identity);
			if (superGolfGun != null)
			{
				superGolfGun.AddForce(SpawnDirection * ThrowForce);
			}
		}
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SpawnClips);
		}
		if (SpawnParticles != null)
		{
			SpawnParticles.Play();
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
