using Core;
using UnityEngine;

public class QWOPShooter : GolfBallShooterBase
{
	public float Force;

	private GolfBallController thisLeg;

	public GolfBallController otherLeg;

	public Vector2 RandomRange;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
