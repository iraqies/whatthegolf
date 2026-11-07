using UnityEngine;

public class SquashAndStretch : MonoBehaviour
{
	private static readonly int SquashID;

	private static readonly int RadiusID;

	private static MaterialPropertyBlock _mpb;

	public MeshRenderer MeshRenderer;

	public float CollisionRadius;

	public float RaycastDistance;

	public bool Use2DPhysics;

	public float Strength;

	public float Dampening;

	public float VelocityStretch;

	public float MaxSpring;

	private float _squash;

	private float _squashVelocity;

	private Vector3 _lastPosition;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
