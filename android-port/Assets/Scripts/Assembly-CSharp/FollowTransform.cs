using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform Target;

	public Vector3 FollowAxis;

	public float FollowSpeed;

	public bool UsePhysics;

	public bool FollowUpVector;

	public bool FollowRotation;

	public bool TransformPositionOffset;

	public bool InverseTransformPositionOffset;

	public Vector3 RotationOffset;

	public Vector3 PositionOffset;

	public Vector3 LookDirectionAxis;

	public Vector2 HeightRange;

	private Rigidbody rigid;

	public float LookSpeed;

	public bool LookAtTarget;

	private void Awake()
	{
	}

	public void ManualFollowUpdate()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private Vector3 GetPosition()
	{
		return default;
	}

	private Quaternion GetRotation()
	{
		return default;
	}

	private Quaternion GetLookRotation()
	{
		return default;
	}
}
