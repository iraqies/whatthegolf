using Core;
using UnityEngine;

public class PaperBoyShooter : GolfBallShooterBase
{
	public GameObject PaperPrefab;

	public float ForceMultiplier;

	private Transform BikePlayerTransform;

	public override void OnShoot(Vector3 boost)
	{
	}
}
