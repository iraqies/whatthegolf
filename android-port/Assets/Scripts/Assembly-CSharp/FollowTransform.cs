using UnityEngine;

public class FollowTransform : MonoBehaviour
{
	public Transform Target;
	public Vector3 FollowAxis = Vector3.one;
	public float FollowSpeed = 1f;
	public bool UsePhysics;
	public bool FollowUpVector = true;
	public bool FollowRotation;
	public bool TransformPositionOffset = true;
	public bool InverseTransformPositionOffset;
	public Vector3 RotationOffset;
	public Vector3 PositionOffset;
	public Vector3 LookDirectionAxis;
	public Vector2 HeightRange = new Vector2(-150f, 150f);
	private Rigidbody rigid;
	public float LookSpeed = 1f;
	public bool LookAtTarget;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	public void ManualFollowUpdate()
	{
		if (UsePhysics)
			FixedUpdate();
		else
			Update();
	}

	private void Update()
	{
		if (UsePhysics || Target == null)
			return;
		transform.position = GetPosition();
		if (FollowUpVector)
			transform.up = Target.up;
		if (FollowRotation)
		{
			transform.rotation = LookAtTarget ? GetLookRotation() : GetRotation();
		}
	}

	private void FixedUpdate()
	{
		if (!UsePhysics || Target == null)
			return;
		Vector3 desired = GetPosition();
		if (rigid != null)
		{
			if (rigid.isKinematic)
			{
				rigid.MovePosition(desired);
			}
			else
			{
				Vector3 delta = desired - rigid.position;
				float dt = Time.fixedDeltaTime > 1e-5f ? Time.fixedDeltaTime : 0.02f;
				rigid.velocity = delta.normalized * (delta.magnitude / dt);
			}
		}
		else
		{
			transform.position = desired;
		}
		if (FollowUpVector)
			transform.up = Target.up;
		if (FollowRotation && rigid != null)
		{
			Quaternion rot = LookAtTarget ? GetLookRotation() : (Target.rotation * Quaternion.Euler(RotationOffset));
			rigid.MoveRotation(rot);
		}
	}

	private Vector3 GetPosition()
	{
		if (Target == null) return transform.position;
		Vector3 cur = transform.position;
		Vector3 tpos = Target.position;
		Vector3 scaledTarget = new Vector3(tpos.x * FollowAxis.x, tpos.y * FollowAxis.y, tpos.z * FollowAxis.z);
		Vector3 off = PositionOffset;
		if (TransformPositionOffset)
			off = Target.InverseTransformDirection(PositionOffset);
		else if (InverseTransformPositionOffset)
			off = Target.TransformDirection(PositionOffset);
		Vector3 desired = scaledTarget + off;
		Vector3 moved = Vector3.MoveTowards(cur, desired, Time.deltaTime * FollowSpeed);
		if (HeightRange.x != 0f || HeightRange.y != 0f)
			moved.y = Mathf.Clamp(moved.y, HeightRange.x, HeightRange.y);
		return new Vector3(
			FollowAxis.x != 0f ? moved.x : cur.x,
			FollowAxis.y != 0f ? moved.y : cur.y,
			FollowAxis.z != 0f ? moved.z : cur.z
		);
	}

	private Quaternion GetRotation()
	{
		if (Target == null) return transform.rotation;
		return Target.rotation * Quaternion.Euler(RotationOffset);
	}

	private Quaternion GetLookRotation()
	{
		if (Target == null) return transform.rotation;
		Vector3 dir = (Target.position - transform.position).normalized;
		dir = new Vector3(dir.x * LookDirectionAxis.x, dir.y * LookDirectionAxis.y, dir.z * LookDirectionAxis.z);
		if (dir.sqrMagnitude <= 1e-6f)
			return rigid != null ? rigid.rotation : transform.rotation;
		Quaternion targetRot = Quaternion.LookRotation(dir, Vector3.up);
		Quaternion curRot = rigid != null ? rigid.rotation : transform.rotation;
		return Quaternion.RotateTowards(curRot, targetRot, LookSpeed * Time.deltaTime);
	}
}
