using Core;
using UnityEngine;

public class SpiderLegsShooter : GolfBallShooterBase
{
	public float fullShootVelocity;

	public SpiderLegs Legs;

	public Transform Body;

	public Animator AnimatorCrab;

	public Animator AnimatorRider;

	public bool UseAddForce { get; set; }

	public override void OnShoot(Vector3 boost)
	{
	}
}
