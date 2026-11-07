using UnityEngine;

public class FollowTransformUtility : MonoBehaviour
{
	[SerializeField]
	public Transform Target;

	[SerializeField]
	private bool ignoreY;

	[SerializeField]
	private bool moveRigidWithVelocity;

	[SerializeField]
	private float FollowSpeed;

	[SerializeField]
	private float FollowDistance;

	private Rigidbody rigid;

	public void SetFollowDistance(int d)
	{
	}

	public void SetFollowTransform(Transform t)
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private Vector3 GetPosition()
	{
		return default;
	}
}
