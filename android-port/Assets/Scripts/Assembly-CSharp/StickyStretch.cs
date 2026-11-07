using UnityEngine;

public class StickyStretch : MonoBehaviour
{
	private static readonly int SquashID;

	private static readonly int RadiusID;

	private static MaterialPropertyBlock _mpb;

	public MeshRenderer MeshRenderer;

	public float CollisionRadius;

	public bool Use2DPhysics;

	public StickyBall Sticky;

	public Vector3 ExtraRotationOffset;

	public float StuckSquash;

	public float UnstuckSquash;

	public float Dampening;

	public float Stiffness;

	public float ValueThreshold;

	private float currentVelocity;

	private bool stuck;

	private float targetSquash;

	private float currentSquash;

	private Vector3 stuckLocalScale;

	private void Start()
	{
	}

	private void OnUnStuck()
	{
	}

	private void OnStuck(Vector3 normal)
	{
	}

	private void LateUpdate()
	{
	}
}
