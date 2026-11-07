using UnityEngine;

public class HorseFoot : MonoBehaviour
{
	[SerializeField]
	private Rigidbody target;

	[SerializeField]
	private float force;

	[SerializeField]
	private float maxAngularVelocity;

	[SerializeField]
	private Vector3 targetPositionScale;

	[SerializeField]
	private Vector3 spherePoint;

	public Vector3 RunVelocity;

	private Rigidbody body;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private Rigidbody MakeDummy()
	{
		return null;
	}
}
