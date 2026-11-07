using System.Collections;
using Core;
using UnityEngine;

public class RattleSnakeShooter : GolfBallShooterStandard
{
	[SerializeField]
	private int length;

	[SerializeField]
	private bool _inPose;

	[SerializeField]
	private Vector3 _poseHeadOffset;

	[SerializeField]
	private Vector3 _bodyPartOffset;

	[SerializeField]
	private Rigidbody _snakeBodyPrefab;

	[SerializeField]
	private Rigidbody _snakeBodyConePrefab;

	[SerializeField]
	private AudioSource _hissAudio;

	[SerializeField]
	private AudioSource _shootAudio;

	private Coroutine _poseTween;

	private float lastShootTime;

	protected override void Awake()
	{
	}

	private void EatCone()
	{
	}

	private IEnumerator MakeDynamic(float delay)
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void ToStandingPose()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void BreakStandingPose()
	{
	}

	private void Update()
	{
	}

	protected override bool IsBlocking()
	{
		return false;
	}

	private void ResetSnake()
	{
	}

	public override void OnReset()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
