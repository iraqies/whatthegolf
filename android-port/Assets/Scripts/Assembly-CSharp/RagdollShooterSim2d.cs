using Core;
using UnityEngine;

public class RagdollShooterSim2d : GolfBallShooterBase
{
	public float Force = 25f;

	public Vector2 RandomRange = new Vector2(0.8f, 1.2f);

	public Rigidbody[] rigidbodies;

	private int groundLayer;

	private bool grounded;

	public float airMultiplier = 0.5f;

	public float maxXWhileFalling;

	private bool constrainX = true;

	public float xCorrectionSpeedMultiplier;

	public float minimumXCorrectionSpeed;

	public float cameraChangeYValue;

	public GameObject CMCamera;

	public float allowedZVariance = 0.5f;

	public float zCorrectionSpeedMultiplier = 2f;

	public float minimumZCorrectionSpeed = 0.5f;

	private float originZ;

	protected override void Awake()
	{
		base.Awake();
		originZ = transform.position.z;
		rigidbodies = GetComponentsInChildren<Rigidbody>();
		if (rigidbodies != null)
		{
			for (int i = rigidbodies.Length - 1; i >= 0; i--)
			{
				if (rigidbodies[i] != null)
					rigidbodies[i].drag = 1f;
			}
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (CMCamera != null && CMCamera.activeInHierarchy && cameraChangeYValue > transform.position.y)
		{
			CMCamera.SetActive(false);
			constrainX = false;
			Force *= 1.2f;
			if (rigidbodies != null)
			{
				for (int i = rigidbodies.Length - 1; i >= 0; i--)
				{
					if (rigidbodies[i] != null)
						rigidbodies[i].drag = 0f;
				}
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (rigidbodies == null || rigidbodies.Length == 0)
			rigidbodies = GetComponentsInChildren<Rigidbody>();
		float mult = grounded ? 1f : (airMultiplier > 0f ? airMultiplier : 0.5f);
		for (int i = 0; i < rigidbodies.Length; i++)
		{
			Rigidbody rb = rigidbodies[i];
			if (rb == null) continue;
			rb.isKinematic = false;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			float rand = RandomRange.sqrMagnitude > 0.001f ? Random.Range(RandomRange.x, RandomRange.y) : 1f;
			rb.AddForce(boost * rand * (Force > 0f ? Force : 25f) * mult, ForceMode.Impulse);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		grounded = true;
	}

	private void OnTriggerExit(Collider other)
	{
		grounded = false;
	}
}
