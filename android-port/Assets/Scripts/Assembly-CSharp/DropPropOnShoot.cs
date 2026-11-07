using System;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class DropPropOnShoot : MonoBehaviour
{
	public PropMuscle MuscleWithProp;

	public GolfBallController Controller;

	public float ForceMod;

	public float UpwardsForce;

	public bool UseAimVector;

	public bool UseObjectVelocity;

	public float MinThrowForce;

	public bool UseAimCurve;

	public Vector3 AimCurveMinDirection;

	public Vector3 AimCurveMaxDirection;

	public AnimationCurve AimCurve;

	public float AngleThreshold;

	public Action<Vector3> OnPropDropped;

	private Vector3 lastObjectVelocity;

	private Vector3 lastAimVector;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ControllerOnOnShoot(Vector3 boost)
	{
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
	}
}
