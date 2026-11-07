using Core;
using UnityEngine;

public class HorseOnSkiisShooter : GolfBallShooterBase
{
	public float Force;

	public float Pitch;

	public Vector2 RandomRange;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	private GolfBallController horseController;

	public GolfBallController catController;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
