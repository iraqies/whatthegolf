using System.Collections.Generic;
using Core;
using UnityEngine;

public class WhackAMoleController : GolfBallShooterBase
{
	[SerializeField]
	private Animator hammerAnimator;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private float blockTime;

	[SerializeField]
	private WinnableGolfBall leftGolfBall;

	[SerializeField]
	private WinnableGolfBall rightGolfBall;

	[SerializeField]
	private List<GameObject> leftGolfBallObstacles;

	[SerializeField]
	private List<GameObject> rightGolfBallObstacles;

	[SerializeField]
	private ParticleSystem obstacleExplosion;

	private float blockTimer;

	private Rigidbody rigid;

	private MultiplayerConfiguration.PlayerInfo player;

	private void Start()
	{
	}

	private void Update()
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
	StandardShoot(boost, 20f, 18f, 5f);
	}

	public void HitSomething()
	{
	}
}
