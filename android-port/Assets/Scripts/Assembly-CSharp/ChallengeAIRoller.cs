using Core;
using UnityEngine;

public class ChallengeAIRoller : MonoBehaviour
{
	public Transform chaseTarget;

	private RollingCowShooter _rollingCowShooter;

	private Vector3 _oldTargetDirection;

	public float aimSpeed = 3f;

	public float lookDistance = 35f;

	[SerializeField]
	private bool DisableKinematicOnEnable;

	private void Start()
	{
		_rollingCowShooter = GetComponent<RollingCowShooter>();
	}

	private void OnEnable()
	{
		if (DisableKinematicOnEnable)
		{
			var rb = gameObject.GetComponentInChildren<Rigidbody>();
			if (rb != null)
			{
				rb.isKinematic = false;
				rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
			}
		}
	}

	private void Update()
	{
		if (chaseTarget == null)
			return;
		if (_rollingCowShooter == null)
			_rollingCowShooter = GetComponent<RollingCowShooter>();
		if (_rollingCowShooter == null)
			return;

		Vector3 dir = (chaseTarget.position - transform.position).normalized;
		float t = Mathf.Clamp01(Time.deltaTime * aimSpeed);
		Vector3 smoothed = Vector3.Lerp(_oldTargetDirection, dir, t);
		float dist = (chaseTarget.position - transform.position).magnitude;
		if (dist > lookDistance)
		{
			_rollingCowShooter.OnShoot(Vector3.zero);
		}
		else
		{
			_rollingCowShooter.OnShoot(smoothed.normalized);
		}
		_oldTargetDirection = smoothed;
	}
}
