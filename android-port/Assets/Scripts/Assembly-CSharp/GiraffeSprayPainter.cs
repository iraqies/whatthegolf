using RootMotion.FinalIK;
using UnityEngine;

public class GiraffeSprayPainter : MonoBehaviour
{
	public GiraffePainterController Controller;

	public CCDIK BodyIK;

	public float WeightChangeSpeed;

	public Collider PlayerCollider;

	public ParticleSystem SpraySystem;

	public ParticleSystemDistanceEmissionCurve EmissionCurve;

	public ParticleSystem.MainModule main;

	private IKSolverCCD solver;

	private float weightTarget;

	private void Awake()
	{
	}

	private void ChangeState(GiraffePainterController.PaintStateEnum newState)
	{
	}

	private void Update()
	{
	}
}
