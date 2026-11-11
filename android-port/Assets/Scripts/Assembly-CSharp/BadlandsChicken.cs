using System;
using Audio;
using CameraStack;
using UnityEngine;

public class BadlandsChicken : MonoBehaviour
{
	public ParticleSystem DeathParticles;

	public float OutOfScreenDeathThreshold = -0.1f;

	public Action<BadlandsChicken> OnDeath;

	public RandomAudioClips deathClips;

	private Camera mainCam;

	private bool dead;

	private Rigidbody rigid;

	private void Awake()
	{
		if (CameraManager.Instance != null)
		{
			mainCam = CameraManager.Instance.MainCamera;
		}
		if (mainCam == null)
		{
			mainCam = Camera.main;
		}
		rigid = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (!dead && GetScreenPosX() < OutOfScreenDeathThreshold)
		{
			Die();
		}
	}

	public void Die()
	{
		if (dead)
		{
			return;
		}
		dead = true;
		if (DeathParticles != null)
		{
			DeathParticles.transform.position = transform.position;
			DeathParticles.Emit(100);
		}
		if (deathClips != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.PlayRandomClip(deathClips);
		}
		OnDeath?.Invoke(this);
		gameObject.SetActive(false);
	}

	public float GetScreenPosX()
	{
		if (mainCam == null)
		{
			mainCam = Camera.main;
		}
		if (mainCam == null)
		{
			return 0.5f;
		}
		return mainCam.WorldToViewportPoint(transform.position).x;
	}

	public Vector3 GetCurrentSpeed()
	{
		return rigid != null ? rigid.velocity : Vector3.zero;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("Obstacle"))
		{
			Die();
		}
	}
}
