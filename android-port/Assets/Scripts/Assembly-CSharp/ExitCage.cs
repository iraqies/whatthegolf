using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ExitCage : MonoBehaviour
{
	[SerializeField]
	private Transform cageTop;

	[SerializeField]
	private Rigidbody cage;

	[SerializeField]
	private CageShooter ball;

	[SerializeField]
	private ParticleSystem breakParticles;

	[SerializeField]
	private List<ExplosionBarrel> leftEscapeBarrels;

	[SerializeField]
	private List<ExplosionBarrel> rightEscapeBarrels;

	[SerializeField]
	private Transform leftBreakFreePosition;

	[SerializeField]
	private Transform rightBreakFreePosition;

	private LobbySpawnPoint.SpawnPointPositions side;

	private bool hasExited;

	private void Start()
	{
		switch (Level.Instance.GetMultiplayerConfiguration().GetPlayerWithIndex(ball.GolfBallController.PlayerID).SpawnSide)
		{
		case LobbySpawnPoint.SpawnPointPositions.Left:
			foreach (ExplosionBarrel leftEscapeBarrel in leftEscapeBarrels)
			{
				leftEscapeBarrel.OnExplode += BarrelOnOnExplode;
			}
			side = LobbySpawnPoint.SpawnPointPositions.Left;
			break;
		case LobbySpawnPoint.SpawnPointPositions.Right:
			foreach (ExplosionBarrel rightEscapeBarrel in rightEscapeBarrels)
			{
				rightEscapeBarrel.OnExplode += BarrelOnOnExplode;
			}
			side = LobbySpawnPoint.SpawnPointPositions.Right;
			break;
		}
	}

	private void BarrelOnOnExplode(Collider arg1, ExplosionBarrel arg2)
	{
		BreakFree((side == LobbySpawnPoint.SpawnPointPositions.Left) ? leftBreakFreePosition.position : rightBreakFreePosition.position);
	}

	public void BreakFree(Vector3 position)
	{
		if (hasExited)
		{
			return;
		}
		breakParticles.transform.position = position;
		breakParticles.Play();
		hasExited = true;
		foreach (Transform item in cage.transform)
		{
			if (item != cageTop.transform)
			{
				Rigidbody rigidbody = item.gameObject.AddComponent<Rigidbody>();
				if (!item.gameObject.name.Contains("Top") && !item.gameObject.name.Contains("Bottom"))
				{
					UnityEngine.Object.Destroy(item.gameObject.GetComponent<CapsuleCollider>());
					item.gameObject.AddComponent<MeshCollider>().convex = true;
				}
				rigidbody.AddForce(cage.velocity, ForceMode.Impulse);
			}
		}
		cage.transform.DetachChildren();
		cageTop.transform.SetParent(cage.transform);
		ball.BreakCage(position);
	}
}
