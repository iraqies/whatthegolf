using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class GunSpawner : MonoBehaviour
{
	public Animator Animator;

	public List<SuperGolfGun> AvailableGuns;

	public Transform SpawnPosition;

	public float ThrowForce;

	public Vector3 SpawnDirection;

	public List<AudioClip> SpawnClips;

	public ParticleSystem SpawnParticles;

	public float AutoUpTime;

	private float cooldown;

	private Timeline timeline;

	private bool playerOnButton;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Trigger()
	{
	}

	public void SpawnNewGun()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
