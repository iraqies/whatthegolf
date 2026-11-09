using Core;
using UnityEngine;

public class RocketArrowShooter : GolfBallShooterBase
{
	private Rigidbody rb;

	public float minShootVelocity;

	public float fullShootVelocity;

	public ParticleSystem particle;

	private GolfBallController controller;

	private bool isAiming;

	private Arrow3D arrow;

	private bool hasAimedOnce;

	[SerializeField]
	private AudioSource rocketAudio;

	private void Start()
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), 5f);
	}

	public override void OnCancel()
	{
	}

	private void HandleCollision(Collision collision)
	{
	}

	private void OnDisable()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void Update()
	{
	}

	protected bool IsPointOutsideCamera(Vector3 p)
	{
		return false;
	}
}
