using Core;
using UnityEngine;

public class ReplicatingHoleShooter : ShooterBase
{
	public GameObject replicatingHolePrefab;

	private Animator animator;

	private GameObject instantiatedNextHole;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
