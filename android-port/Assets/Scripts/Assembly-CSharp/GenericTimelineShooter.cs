using System.Collections.Generic;
using Chronos;
using Core;
using UnityEngine;

public class GenericTimelineShooter : GolfBallShooterBase
{
	[SerializeField]
	private Timeline timeline;

	[SerializeField]
	private List<Clock> clocks;

	[SerializeField]
	private float aimTimeScale;

	[SerializeField]
	private float upSpeed;

	[SerializeField]
	private float downSpeed;

	[SerializeField]
	public float minShootVelocity;

	[SerializeField]
	public float fullShootVelocity;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve;

	[SerializeField]
	public float spin;

	[SerializeField]
	protected bool lookInShotDirection;

	public bool lookInAimDirection;

	public float LookInAimDirectionSpeed;

	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[SerializeField]
	protected bool useLocalUp;

	[SerializeField]
	public bool zeroPitchIfNotGrouneded;

	public override void OnActivate()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
	{
	}
}
