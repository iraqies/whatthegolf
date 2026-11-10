using System;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	[SerializeField]
	private float distance;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float normalizedStartPosition = 0.5f;

	[SerializeField]
	private float startDirection = 1f;

	[SerializeField]
	private bool useUnscaledTime = true;

	private float dir = 1f;

	private Vector3 startPos;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private Vector3 right = Vector3.right;

	public Action OnTurn;

	private void Start()
	{
		right = base.transform.right;
		dir = startDirection;
		startPos = base.transform.position;
		rigid = GetComponentInChildren<Rigidbody>();
		rigid2D = GetComponentInChildren<Rigidbody2D>();
		Vector3 halfSpan = right * distance * 0.5f;
		Vector3 minPos = startPos - halfSpan;
		Vector3 maxPos = startPos + halfSpan;
		base.transform.position = Vector3.Lerp(minPos, maxPos, Mathf.Clamp01(normalizedStartPosition));
	}

	private void FixedUpdate()
	{
		Vector3 halfSpan = right * distance * 0.5f;
		Vector3 maxPos = startPos + halfSpan;
		Vector3 minPos = startPos - halfSpan;
		Vector3 toMinDir = (minPos - maxPos).normalized;
		Vector3 fromMaxDir = (maxPos - base.transform.position).normalized;
		if (dir > 0f && Vector3.Dot(toMinDir, fromMaxDir) != -1f)
		{
			dir = 0f - dir;
			MoveRigid(maxPos, false);
			OnTurn?.Invoke();
		}
		Vector3 toMaxDir = (maxPos - minPos).normalized;
		Vector3 fromMinDir = (minPos - base.transform.position).normalized;
		if (dir < 0f && Vector3.Dot(toMaxDir, fromMinDir) != -1f)
		{
			dir = 0f - dir;
			MoveRigid(minPos, false);
			OnTurn?.Invoke();
		}
		float dt = (useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime);
		Vector3 curPos;
		if (rigid != null)
		{
			curPos = rigid.position;
		}
		else if (rigid2D != null)
		{
			Vector2 p2 = rigid2D.position;
			curPos = new Vector3(p2.x, p2.y, 0f);
		}
		else
		{
			curPos = base.transform.position;
		}
		MoveRigid(curPos + right * (dt * speed * dir), true);
	}

	private void MoveRigid(Vector3 position, bool useMovePosition)
	{
		if (useMovePosition)
		{
			if (rigid != null)
			{
				rigid.MovePosition(position);
			}
			else if (rigid2D != null)
			{
				rigid2D.MovePosition(new Vector2(position.x, position.y));
			}
			else
			{
				base.transform.position = position;
			}
		}
		else if (rigid != null)
		{
			rigid.position = position;
		}
		else if (rigid2D != null)
		{
			rigid2D.position = new Vector2(position.x, position.y);
		}
		else
		{
			base.transform.position = position;
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
