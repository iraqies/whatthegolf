using System.Collections.Generic;
using Core;
using UnityEngine;

public class RotateRigidbodyWhenAiming : MonoBehaviour
{
	public GolfBallController controller;

	public float RotateSpeed;

	public ParticleSystem DoneParticles;

	public List<AudioClip> DoneClips;

	private Vector3 restingRotationEuler;

	private Rigidbody rigidbody;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
