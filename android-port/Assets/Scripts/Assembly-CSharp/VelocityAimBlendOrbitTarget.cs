using Core;
using UnityEngine;

public class VelocityAimBlendOrbitTarget : MonoBehaviour
{
	public Rigidbody rigidbody;

	public float distance;

	public float elevation;

	public float speed;

	public float aimLengthThreshold;

	public AnimationCurve forwardToVelocityBlend;

	public GolfBallController ball;

	private Vector3 aimDir;

	private void Start()
	{
	}

	private void Ball_OnAimStart()
	{
	}

	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	private void Update()
	{
	}
}
