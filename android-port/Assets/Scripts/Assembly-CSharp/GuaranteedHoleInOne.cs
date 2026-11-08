using Core;
using UnityEngine;

public class GuaranteedHoleInOne : GolfBallShooterBase
{
	public Transform Target;

	public float HeightMod;

	public float Duration;

	public int NumberOfJumps;

	private bool hasShot;

	private Vector3 startPos;

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}
}
