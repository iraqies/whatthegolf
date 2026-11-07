using System.Collections;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{
	[SerializeField]
	private bool startOnAwake;

	[SerializeField]
	private float arcRange;

	[SerializeField]
	private float speedFactor;

	[SerializeField]
	private float timeOffset;

	[SerializeField]
	private AnimationCurve rotationCurve;

	[SerializeField]
	private ParticleSystem shootParticles;

	[SerializeField]
	private Transform shootPointTransform;

	[SerializeField]
	private float shootForce;

	[SerializeField]
	private Rigidbody cannonBall;

	private Rigidbody _rigidbody;

	private Quaternion _startRotation;

	private Vector3 axis;

	private float time;

	private bool isRotating;

	public void StartRotating()
	{
	}

	public void StopRotating()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private IEnumerator ShootCannonRoutine()
	{
		return null;
	}
}
