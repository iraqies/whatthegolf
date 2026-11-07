using Core;
using UnityEngine;

public class BallForBushes : MonoBehaviour
{
	[SerializeField]
	public float sqrMagnitudeThreshold;

	[SerializeField]
	private Rigidbody rigidbody;

	[SerializeField]
	private bool AddToControllerBlockingFunctions;

	private GolfBallController controller;

	private float _orgSqrVelocity;

	private float sqrVelocity;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void Awake()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	public bool IsBlocking()
	{
		return false;
	}
}
