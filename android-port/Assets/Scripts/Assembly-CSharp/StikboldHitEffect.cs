using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class StikboldHitEffect : MonoBehaviour
{
	public FinalLevel FinalLevel;

	public BallSpawner BallSpawner;

	public Transform Center;

	public float Force;

	public GameObject Collider;

	public ParticleSystem Particles;

	public CameraManager Manager;

	private List<GolfBallController> controllers;

	private void Start()
	{
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo hitPlayer, int health)
	{
	}
}
