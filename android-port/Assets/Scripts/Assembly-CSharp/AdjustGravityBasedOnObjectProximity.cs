using Core;
using UnityEngine;

public class AdjustGravityBasedOnObjectProximity : MonoBehaviour
{
	public LayerMask Mask;

	public float RaycastDistance = 10f;

	public float MaxWaitTime = 5f;

	public float PullForce = 10f;

	private Rigidbody rigidbody;

	private float waitTime;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		Level.Instance.Ball.OnShoot += Ball_OnShoot;
	}

	private void Ball_OnShoot(Vector3 boost)
	{
		waitTime = Mathf.Max(1f, MaxWaitTime * boost.magnitude);
	}

	private void Update()
	{
		waitTime -= Time.deltaTime;
		if (!(waitTime > 0f) && Physics.Raycast(base.transform.position, Vector3.down, out var hitInfo, RaycastDistance, Mask) && hitInfo.distance > 1f)
		{
			Vector3 normalized = (hitInfo.point - base.transform.position).normalized;
			rigidbody.AddForce(normalized * PullForce);
		}
	}
}
