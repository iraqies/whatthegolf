using Core;
using UnityEngine;

public class BanjoShooter2D : ShooterBase
{
	[SerializeField]
	private float aimSpringFactor = 100f;

	[SerializeField]
	private float maxAngularVelocity = float.PositiveInfinity;

	[SerializeField]
	private float maxAngleDelta = 10f;

	[SerializeField]
	private float springDampAngle = 5f;

	[SerializeField]
	private float springDampPower = 2f;

	[SerializeField]
	private Rigidbody2D grabRigidbody;

	[SerializeField]
	private Vector2 centerOfMass;

	[SerializeField]
	private float shootForce;

	private Rigidbody2D rigidbody2D;

	private FixedJoint2D grabJoint;

	private Vector3 grabLocalPosition;

	private void Awake()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
		if (rigidbody2D != null)
		{
			rigidbody2D.centerOfMass = centerOfMass;
		}
		if (grabRigidbody != null)
		{
			grabLocalPosition = grabRigidbody.transform.localPosition;
		}
	}

	public override void OnAimStart()
	{
		if (grabRigidbody != null)
		{
			grabRigidbody.gameObject.SetActive(true);
			grabRigidbody.transform.localPosition = grabLocalPosition;
		}
		grabJoint = base.gameObject.AddComponent<FixedJoint2D>();
		if (grabJoint != null)
		{
			grabJoint.connectedBody = grabRigidbody;
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (onlyAimArrow)
			return;

		Vector3 normBoost = boost.normalized;
		Vector3 right = base.transform.right;
		float angle = Vector2.SignedAngle(new Vector2(-right.x, -right.y), new Vector2(normBoost.x, normBoost.y));
		float clampedAngle = Mathf.Clamp(angle, -maxAngleDelta, maxAngleDelta);
		float dampFactor = Mathf.Pow(Mathf.InverseLerp(0f, springDampAngle, Mathf.Abs(clampedAngle)), springDampPower);
		if (grabRigidbody != null)
		{
			grabRigidbody.angularVelocity = aimSpringFactor * clampedAngle * dampFactor;
		}
		if (rigidbody2D != null)
		{
			rigidbody2D.angularVelocity = Mathf.Clamp(rigidbody2D.angularVelocity, -maxAngularVelocity, maxAngularVelocity);
		}
	}

	public override void OnCancel()
	{
		ReleaseGrab();
	}

	public override void OnShoot(Vector3 boost)
	{
		if (rigidbody2D != null)
		{
			rigidbody2D.AddForce(new Vector2(boost.x * shootForce, boost.y * shootForce), ForceMode2D.Impulse);
		}
		ReleaseGrab();
	}

	private void ReleaseGrab()
	{
		if (grabRigidbody != null)
		{
			grabRigidbody.gameObject.SetActive(false);
		}
		if (grabJoint != null)
		{
			Object.Destroy(grabJoint);
			grabJoint = null;
		}
	}

	private void OnHitGoal()
	{
		if (Level.Instance != null && Level.Instance.Goal != null)
		{
			Level.Instance.Goal.Complete();
		}
	}
}
