using UnityEngine;

public class GroundedTrailRenderer : MonoBehaviour
{
	public float GroundDistCheck;

	public LayerMask GroundMask;

	public TrailRenderer Trail;

	public ParticleSystem particles;

	public ConstantForce2D LeftForce;

	public ConstantForce2D RightForce;

	public bool inAir;

	private ParticleSystem.EmissionModule emission;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
