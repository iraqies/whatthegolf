using System;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class DropPropOnShoot : MonoBehaviour
{
	public PropMuscle MuscleWithProp;

	public GolfBallController Controller;

	public float ForceMod = 20f;

	public float UpwardsForce = 5f;

	public bool UseAimVector = true;

	public bool UseObjectVelocity;

	public float MinThrowForce = 5f;

	public bool UseAimCurve;

	public Vector3 AimCurveMinDirection;

	public Vector3 AimCurveMaxDirection;

	public AnimationCurve AimCurve;

	public float AngleThreshold = 45f;

	public Action<Vector3> OnPropDropped;

	private Vector3 lastObjectVelocity;

	private Vector3 lastAimVector;

	private void Start()
	{
		if (Controller != null)
		{
			Controller.OnShoot += ControllerOnOnShoot;
		}
	}

	private void FixedUpdate()
	{
		if (MuscleWithProp != null && MuscleWithProp.currentProp != null)
		{
			Rigidbody rb = MuscleWithProp.currentProp.GetRigidbody();
			if (rb != null)
			{
				lastObjectVelocity = rb.velocity;
			}
		}
	}

	private void ControllerOnOnShoot(Vector3 boost)
	{
		lastAimVector = boost;
		if (MuscleWithProp != null && MuscleWithProp.currentProp != null)
		{
			PuppetMasterProp prop = MuscleWithProp.currentProp;
			MuscleWithProp.currentProp = null;
			OnDropProp(prop);
		}
		OnPropDropped?.Invoke(boost);
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
		if (prop == null)
		{
			return;
		}
		Rigidbody rb = prop.GetRigidbody();
		if (rb != null)
		{
			Vector3 force = UseAimVector ? lastAimVector * ForceMod + Vector3.up * UpwardsForce : lastObjectVelocity * ForceMod;
			rb.AddForce(force, ForceMode.Impulse);
		}
	}
}
