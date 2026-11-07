using UnityEngine;

public class AdjustGravityBasedOnObjectProximity : MonoBehaviour
{
	public LayerMask Mask;

	public float RaycastDistance;

	public float MaxWaitTime;

	public float PullForce;

	private Rigidbody rigidbody;

	private float waitTime;

	private void Start()
	{
	}

	private void Ball_OnShoot(Vector3 boost)
	{
	}

	private void Update()
	{
	}
}
