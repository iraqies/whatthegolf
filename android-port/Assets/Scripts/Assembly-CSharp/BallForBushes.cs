using Core;
using UnityEngine;

public class BallForBushes : MonoBehaviour
{
	[SerializeField]
	public float sqrMagnitudeThreshold = 50f;

	[SerializeField]
	private Rigidbody rigidbody;

	[SerializeField]
	private bool AddToControllerBlockingFunctions;

	private GolfBallController controller;

	private float _orgSqrVelocity;

	private float sqrVelocity;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			sqrMagnitudeThreshold = _orgSqrVelocity;
			controller.AffectTime = false;
		}
	}

	private void Awake()
	{
		_orgSqrVelocity = sqrMagnitudeThreshold;
		controller = GetComponent<GolfBallController>();
		controller.AddBlockingFunction(IsBlocking);
		controller.OnShoot += ControllerOnOnShoot;
		if (rigidbody == null)
		{
			rigidbody = GetComponent<Rigidbody>();
		}
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		controller.AffectTime = false;
	}

	public bool IsBlocking()
	{
		sqrVelocity = 0f;
		sqrVelocity = rigidbody.velocity.sqrMagnitude;
		return sqrVelocity > sqrMagnitudeThreshold;
	}
}
