using UnityEngine;

public class FollowParticles : MonoBehaviour
{
	public ParticleSystem System;

	public GameObject ObjectsThatFollow;

	private ParticleSystem.Particle[] particles;

	private GameObject[] objects;

	public float m_Drift;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void InitializeIfNeeded()
	{
	}
}
