using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform Target;
	public Vector3 FollowAxis = Vector3.one;
	public float FollowSpeed = 20f;
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
	public float LookSpeed = 10f;
	public bool LookAtTarget;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	public void ManualFollowUpdate()
	{
		if (Target == null) return;
		transform.position = GetPosition();
		if (FollowRotation || LookAtTarget)
			transform.rotation = GetRotation();
	}

	private void Update()
	{
		if (!UsePhysics) ManualFollowUpdate();
	}

	private void FixedUpdate()
	{
		if (UsePhysics) ManualFollowUpdate();
	}

	private Vector3 GetPosition()
	{
		if (Target == null) return transform.position;
		Vector3 offset = TransformPositionOffset ? Target.TransformVector(PositionOffset) : PositionOffset;
		Vector3 targetPos = Target.position + offset;
		Vector3 cur = transform.position;
		Vector3 next = new Vector3(
			FollowAxis.x != 0f ? targetPos.x : cur.x,
			FollowAxis.y != 0f ? targetPos.y : cur.y,
			FollowAxis.z != 0f ? targetPos.z : cur.z
		);
		return FollowSpeed > 0f ? Vector3.Lerp(cur, next, Time.deltaTime * FollowSpeed) : next;
	}

	private Quaternion GetRotation()
	{
		if (Target == null) return transform.rotation;
		if (LookAtTarget) return GetLookRotation();
		return Target.rotation * Quaternion.Euler(RotationOffset);
	}

	private Quaternion GetLookRotation()
	{
		Vector3 dir = Target.position - transform.position;
		return dir.sqrMagnitude > 1e-4f ? Quaternion.LookRotation(dir.normalized) : transform.rotation;
	}
}
