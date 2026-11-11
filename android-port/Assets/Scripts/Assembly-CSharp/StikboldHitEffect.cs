using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class StikboldHitEffect : MonoBehaviour
{
	public FinalLevel FinalLevel;

	public BallSpawner BallSpawner;

	public Transform Center;

	public float Force = 100f;

	public GameObject Collider;

	public ParticleSystem Particles;

	public CameraManager Manager;

	private List<GolfBallController> controllers = new List<GolfBallController>();

	private void Start()
	{
		FinalLevel finalLevel = FinalLevel;
		finalLevel.PlayerHealthChanged = (Action<MultiplayerConfiguration.PlayerInfo, int>)Delegate.Combine(finalLevel.PlayerHealthChanged, new Action<MultiplayerConfiguration.PlayerInfo, int>(PlayerHealthChanged));
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += InstanceOnOnMultiplayerSetup;
		}
	}

	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
		foreach (MultiplayerConfiguration.PlayerInfo player in Level.Instance.GetMultiplayerConfiguration().Players)
		{
			foreach (GolfBallController controller in player.Controllers)
			{
				controllers.Add(controller);
			}
		}
	}

	private void PlayerHealthChanged(MultiplayerConfiguration.PlayerInfo hitPlayer, int health)
	{
		Vector3 position = hitPlayer.Controllers[0].transform.position;
		Particles.transform.position = position;
		Particles.Play();
		Collider.SetActive(true);
		foreach (MultiplayerConfiguration.PlayerInfo player in Level.Instance.GetMultiplayerConfiguration().Players)
		{
			if (player != hitPlayer)
			{
				Vector3 normalized = (player.Controllers[0].transform.position - position).normalized;
				player.Controllers[0].GetComponent<Rigidbody>().velocity = normalized * Force;
				Vector3 normalized2 = (position - player.Controllers[0].transform.position).normalized;
				hitPlayer.Controllers[0].GetComponent<Rigidbody>().velocity = normalized2 * Force / 5f;
			}
		}
		foreach (GameObject ball in BallSpawner.GetBalls())
		{
			if (!ball.TryGetComponent<SuperGolfThrowableWeapon>(out var component) || !component.IsBeingHeld())
			{
				Vector3 normalized3 = (ball.transform.position - position).normalized;
				ball.GetComponent<Rigidbody>().velocity = normalized3 * Force;
			}
		}
		Manager.Shake(0.5f, 20f, 2f);
		foreach (GolfBallController controller in controllers)
		{
			controller.TimedBlockShot(0.5f);
		}
	}
}
