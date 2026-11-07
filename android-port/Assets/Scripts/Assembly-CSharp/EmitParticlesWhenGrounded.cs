using UnityEngine;

public class EmitParticlesWhenGrounded : MonoBehaviour
{
	public Vector3 Offset;

	public float Distance;

	public LayerMask GroundLayers;

	public float ParticlesToEmitPerUnit;

	private RealCar[] cars;

	private ParticleSystem particles;

	private Vector3[] lastPositions;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void EmitForWheel(Transform wheel, int i)
	{
	}
}
