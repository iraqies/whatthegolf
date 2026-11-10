using UnityEngine;

public class HorseShooter : MonoBehaviour
{
	[SerializeField]
	private Transform frontTransform;

	[SerializeField]
	private Transform backTransform;

	[SerializeField]
	private float distance = 3.5f;

	private Rigidbody rigidbody;

	private float sphereCastRadius = 0.1f;

	private int layerMask;

	private void Awake()
	{
		layerMask = ~LayerMask.GetMask("Ball");
		rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (frontTransform == null || backTransform == null || rigidbody == null)
			return;
		Vector3 frontPos = frontTransform.position;
		CalculateTarget(frontPos);
		CalculateTarget(backTransform.position);
		rigidbody.AddForceAtPosition(Vector3.forward * 500f, frontPos);
	}

	private Vector3 CalculateTarget(Vector3 position)
	{
		Ray ray = new Ray(position, Vector3.down);
		if (Physics.SphereCast(ray, sphereCastRadius, out RaycastHit hit, distance, layerMask))
		{
			return position + Vector3.down * (hit.distance - distance);
		}
		return position;
	}

	public void Bounce()
	{
	}
}
