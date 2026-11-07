using Core;
using RootMotion.FinalIK;
using UnityEngine;

public class GiraffeSculptorController : GolfBallShooterBase
{
	public Transform PointContainer;

	public Transform Mover;

	public Transform ToungeRoot;

	public CCDIK motor;

	private int currentPointIndex;

	private Vector3 refVel;

	private Vector3 toungeScale;

	private float targetWeight;

	private void Start()
	{
	}

	private void OnComplete(Level.CompletedState obj)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void Update()
	{
	}
}
