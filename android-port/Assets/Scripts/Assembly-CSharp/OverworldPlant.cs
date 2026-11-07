using System;
using Audio;
using UnityEngine;

public class OverworldPlant : GolfBehaviour, IAudioEvent
{
	private float nextHitSound;

	[SerializeField]
	private Collider2D col;

	private Transform baseTransform;

	private Quaternion baseRotation;

	public int particleAmount;

	[SerializeField]
	private PlantParticles plantParticles;

	private OverworldBallManager overworldBallManager;

	public Action<Vector3> OnAudioEvent { get; set; }

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
