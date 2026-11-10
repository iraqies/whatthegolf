using UnityEngine;

public class AddForce : MonoBehaviour
{
	public bool onAwake;

	public bool useTransformAsTarget;

	public Transform target;

	public Vector3 forceDir;

	public float forceMagnitude;

	public Vector3 rotationDir;

	public float rotationForce;

	public float delay;

	public ForceMode mode;

	private Rigidbody rigid;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		if (onAwake)
		{
			Execute();
		}
	}

	public void Execute()
	{
		SetForceDirAndRot();
		if (delay > 0f)
		{
			StartCoroutine(pTween.To(delay, delegate
			{
			}).Then(delegate
			{
				if (rigid != null)
				{
					rigid.AddForce(forceDir.normalized * forceMagnitude, mode);
				}
			}));
			return;
		}
		if (rigid != null)
		{
			rigid.AddForce(forceDir.normalized * forceMagnitude, mode);
			rigid.AddTorque(rotationDir.normalized * rotationForce);
		}
	}

	public void OnDrawGizmos()
	{
		if (useTransformAsTarget && target == null)
		{
			return;
		}
		SetForceDirAndRot();
		Gizmos.color = Color.yellow;
		Vector3 position = base.transform.position;
		Vector3 vector = base.transform.position + forceDir.normalized * forceMagnitude;
		Gizmos.DrawLine(position, vector);
		if (Camera.current != null)
		{
			Vector3 vector2 = position - vector;
			Vector3 forward = Camera.current.transform.forward;
			Gizmos.DrawLine(vector, vector + Quaternion.AngleAxis(30f, forward) * vector2 * 0.1f);
			Gizmos.DrawLine(vector, vector + Quaternion.AngleAxis(-30f, forward) * vector2 * 0.1f);
		}
	}

	private void SetForceDirAndRot()
	{
		if (useTransformAsTarget && target != null)
		{
			forceDir = target.position - base.transform.position;
			rotationDir = target.rotation.eulerAngles;
		}
	}
}
