using Core;
using UnityEngine;

public class VelocityAimBlendOrbitTarget : MonoBehaviour
{
	public Rigidbody rigidbody;

	public float distance = 10f;

	public float elevation;

	public float speed = 10f;

	public float aimLengthThreshold = 0.1f;

	public AnimationCurve forwardToVelocityBlend;

	public GolfBallController ball;

	private Vector3 aimDir;

	private void Start()
	{
		if (rigidbody != null)
		{
			base.transform.position = rigidbody.transform.position + rigidbody.transform.forward * distance + Vector3.up * elevation;
			aimDir = rigidbody.transform.forward;
		}
		if (ball != null)
		{
			ball.OnAimUpdate += Ball_OnAimUpdate;
			ball.OnAimStart += Ball_OnAimStart;
		}
	}

	private void Ball_OnAimStart()
	{
		if (rigidbody != null)
		{
			aimDir = rigidbody.transform.forward;
		}
	}

	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
		if (arg1.magnitude > aimLengthThreshold)
		{
			aimDir = arg1.normalized;
		}
	}

	private void Update()
	{
		if (rigidbody == null)
		{
			return;
		}
		Vector3 aimTarget = rigidbody.transform.position + aimDir * distance;
		float velMag = rigidbody.velocity.magnitude;
		Vector3 targetPos;
		if (velMag > 0.1f && forwardToVelocityBlend != null)
		{
			Vector3 velTarget = rigidbody.transform.position + rigidbody.velocity.normalized * distance;
			float blend = Mathf.Clamp01(forwardToVelocityBlend.Evaluate(velMag));
			targetPos = Vector3.Lerp(aimTarget, velTarget, blend) + Vector3.up * elevation;
		}
		else
		{
			targetPos = aimTarget + Vector3.up * elevation;
		}
		base.transform.position = Vector3.Lerp(base.transform.position, targetPos, Mathf.Clamp01(speed * Time.deltaTime));
	}
}
