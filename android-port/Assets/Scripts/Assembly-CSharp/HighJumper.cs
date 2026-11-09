using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class HighJumper : GolfBall2DShooterBase
{
	[Serializable]
	public class Judge
	{
		public Transform SignPivot;

		public List<ConstantForce2D> Hands;
	}

	[Serializable]
	public class JumpStage
	{
		public JumpStateEnum JumpState;

		public Transform CameraFollow;

		public float OrthographicSize;

		public float TimeScale;

		public float BlockTime;

		public float TimeScaleRevert;
	}

	public enum JumpStateEnum
	{
		OnSpringBoard = 0,
		InAir = 1,
		InWater = 2,
		GettingJudged = 3
	}

	public List<JumpStage> JumpStages;

	public List<ConstantForce2D> ForceAppliers;

	public Collider2D Water;

	public ParticleSystem WaterParticles;

	public List<Judge> Judges;

	public BoxCollider2D OnBoardTrigger;

	public bool instantWin;

	public float winWaitTime;

	[SerializeField]
	private float minShootVelocity;

	[SerializeField]
	private float fullShootVelocity;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float spin;

	[SerializeField]
	private JumpStateEnum currentJumpState;

	public Action onJump;

	private TimeControl timeControl;

	public Rigidbody2D[] rigidbodies;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), spin);
	}

	private void ChangeJumpState(JumpStateEnum newState)
	{
	}

	private void ReverseForces()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D col)
	{
	}

	private IEnumerator JudgeVerdicts()
	{
		return null;
	}
}
