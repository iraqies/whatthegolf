using UnityEngine;

public class StickyStretch : MonoBehaviour
{
	private static readonly int SquashID = Shader.PropertyToID("_Squash");

	private static readonly int RadiusID = Shader.PropertyToID("_Radius");

	private static MaterialPropertyBlock _mpb;

	public MeshRenderer MeshRenderer;

	public float CollisionRadius = 0.5f;

	public bool Use2DPhysics;

	public StickyBall Sticky;

	public Vector3 ExtraRotationOffset;

	public float StuckSquash = -0.35f;

	public float UnstuckSquash;

	public float Dampening = 10f;

	public float Stiffness = 300f;

	public float ValueThreshold = 0.01f;

	private float currentVelocity;

	private bool stuck;

	private float targetSquash;

	private float currentSquash;

	private Vector3 stuckLocalScale;

	private void Start()
	{
		if (MeshRenderer == null)
			MeshRenderer = GetComponent<MeshRenderer>();
		if (Sticky == null)
			Sticky = GetComponentInParent<StickyBall>();
		if (Sticky != null)
		{
			Sticky.OnStuck -= OnStuck;
			Sticky.OnStuck += OnStuck;
			Sticky.OnUnStuck -= OnUnStuck;
			Sticky.OnUnStuck += OnUnStuck;
		}
		if (Use2DPhysics)
		{
			Collider2D col2d = GetComponentInParent<Collider2D>();
			if (col2d != null)
				CollisionRadius = col2d.bounds.extents.x;
		}
		else
		{
			Collider col = GetComponentInParent<Collider>();
			if (col != null)
				CollisionRadius = col.bounds.extents.x;
		}
		if (CollisionRadius <= 0f)
			CollisionRadius = 0.5f;

		if (_mpb == null)
			_mpb = new MaterialPropertyBlock();
		if (MeshRenderer != null)
		{
			MeshRenderer.GetPropertyBlock(_mpb);
			_mpb.SetFloat(RadiusID, CollisionRadius);
			MeshRenderer.SetPropertyBlock(_mpb);
		}
	}

	private void OnUnStuck()
	{
		targetSquash = UnstuckSquash;
		stuck = false;
	}

	private void OnStuck(Vector3 normal)
	{
		stuck = true;
		stuckLocalScale = transform.localScale;
		transform.rotation = Quaternion.LookRotation(normal);
		transform.Rotate(ExtraRotationOffset, Space.Self);
		targetSquash = StuckSquash;
	}

	private void LateUpdate()
	{
		if (_mpb == null)
			_mpb = new MaterialPropertyBlock();
		if (MeshRenderer == null)
			return;

		float dt = Time.deltaTime;
		float dampFactor = 1f - Dampening * dt;
		if (dampFactor >= 0f)
		{
			float accel = (targetSquash - currentSquash) * Stiffness * dt;
			currentVelocity = (currentVelocity + accel) * dampFactor;
			float nextSquash = currentSquash + currentVelocity * dt;
			if (currentVelocity * currentVelocity < ValueThreshold && (targetSquash - nextSquash) * (targetSquash - nextSquash) < ValueThreshold)
			{
				currentVelocity = 0f;
				currentSquash = targetSquash;
			}
			else
			{
				currentSquash = nextSquash;
			}
		}
		else
		{
			currentVelocity = 0f;
			currentSquash = targetSquash;
		}

		MeshRenderer.GetPropertyBlock(_mpb);
		_mpb.SetFloat(SquashID, currentSquash);
		_mpb.SetFloat(RadiusID, CollisionRadius);
		MeshRenderer.SetPropertyBlock(_mpb);
	}
}
