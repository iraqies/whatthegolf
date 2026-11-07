using System.Collections.Generic;
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
	}

	private void BarrelOnOnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	public void BreakFree(Vector3 position)
	{
	}
}
