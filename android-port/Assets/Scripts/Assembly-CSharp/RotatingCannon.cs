using System.Collections;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{
	[SerializeField]
	private bool startOnAwake;

	[SerializeField]
	private float arcRange;

	[SerializeField]
	private float speedFactor = 1f;

	[SerializeField]
	private float timeOffset;

	[SerializeField]
	private AnimationCurve rotationCurve;

	[SerializeField]
	private ParticleSystem shootParticles;

	[SerializeField]
	private Transform shootPointTransform;

	[SerializeField]
	private float shootForce = 150f;

	[SerializeField]
	private Rigidbody cannonBall;

	private Rigidbody _rigidbody;

	private Quaternion _startRotation;

	private Vector3 axis = Vector3.up;

	private float time;

	private bool isRotating;

	public void StartRotating()
	{
		isRotating = true;
	}

	public void StopRotating()
	{
		isRotating = false;
	}

	private void Awake()
	{
		isRotating = startOnAwake;
		if (rotationCurve != null)
		{
			rotationCurve.postWrapMode = WrapMode.PingPong;
		}
		if (TryGetComponent<Rigidbody>(out _rigidbody))
		{
			_startRotation = _rigidbody.rotation;
		}
	}

	private void FixedUpdate()
	{
		if (!(_rigidbody == null) && isRotating)
		{
			time += Time.fixedDeltaTime;
			float angle = arcRange * (rotationCurve.Evaluate(timeOffset + time * speedFactor) * 2f - 1f);
			_rigidbody.MoveRotation(_startRotation * Quaternion.AngleAxis(angle, axis));
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!isRotating || collision == null || collision.collider == null || !collision.collider.TryGetComponent<CannonShootable>(out var _))
		{
			return;
		}
		if (shootParticles != null)
		{
			shootParticles.Play();
		}
		if (cannonBall != null && shootPointTransform != null)
		{
			Rigidbody rigidbody = Object.Instantiate(cannonBall, shootPointTransform.position, Quaternion.identity);
			if (rigidbody != null)
			{
				Physics.IgnoreCollision(rigidbody.GetComponent<Collider>(), GetComponent<Collider>(), true);
				rigidbody.velocity = shootPointTransform.forward * shootForce;
			}
		}
		StartCoroutine(ShootCannonRoutine());
	}

	private IEnumerator ShootCannonRoutine()
	{
		StopRotating();
		yield return new WaitForSeconds(1f);
		StartRotating();
	}
}
