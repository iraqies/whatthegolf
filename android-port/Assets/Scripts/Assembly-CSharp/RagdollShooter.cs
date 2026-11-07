using Core;
using UnityEngine;
using UnityEngine.Events;

public class RagdollShooter : GolfBallShooterBase
{
	public float Force;

	public float Pitch;

	public Vector2 RandomRange;

	public bool ignoreTail;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	public UnityEvent BeforeFirstShot;

	public bool FullPowerOnFirstShot;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
