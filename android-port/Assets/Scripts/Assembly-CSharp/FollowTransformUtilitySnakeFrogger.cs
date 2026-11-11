using UnityEngine;

public class FollowTransformUtilitySnakeFrogger : MonoBehaviour
{
	[SerializeField]
	public Transform Target;

	[SerializeField]
	private bool ignoreY;

	[SerializeField]
	private bool moveRigidWithVelocity = true;

	[SerializeField]
	private float FollowSpeed = 1f;

	[SerializeField]
	private float FollowDistance;

	private Rigidbody rigid;

	private Transform previousChild;

	private bool isDestroyed;

	public void SetFollowDistance(int d)
	{
		FollowDistance = d;
	}

	public void SetFollowTransform(Transform t)
	{
		Target = t;
	}

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (Target == null && transform.parent != null)
		{
			Transform p = transform.parent;
			int maxIdx = p.childCount - 1;
			for (int i = 0; i < maxIdx; i++)
			{
				if (i > 0 && p.GetChild(i) == transform)
				{
					previousChild = p.GetChild(i - 1);
				}
				Target = previousChild;
			}
		}
		if (Target == null || rigid == null)
		{
			return;
		}
		Vector3 targetPos = GetPosition();
		if (moveRigidWithVelocity)
		{
			Vector3 delta = targetPos - rigid.position;
			Vector3 dir = delta.normalized;
			float dist = delta.magnitude;
			float dt = Time.fixedDeltaTime;
			if (dt > 0f)
			{
				float vy = ignoreY ? rigid.velocity.y : (dir.y * dist / dt);
				rigid.velocity = new Vector3(dir.x * dist / dt, vy, dir.z * dist / dt);
			}
		}
		else
		{
			Vector3 cur = rigid.position;
			float t = Mathf.Clamp01(Time.deltaTime * FollowSpeed);
			rigid.MovePosition(Vector3.Lerp(cur, targetPos, t));
		}
	}

	private Vector3 GetPosition()
	{
		if (Target == null || rigid == null)
		{
			return transform.position;
		}
		Vector3 dir = (rigid.position - Target.position).normalized;
		Vector3 desired = Target.position + dir * FollowDistance;
		return Vector3.MoveTowards(transform.position, desired, FollowSpeed * Time.deltaTime);
	}
}
