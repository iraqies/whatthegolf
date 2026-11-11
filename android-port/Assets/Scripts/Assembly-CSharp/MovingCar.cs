using System;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
	public delegate void OnStoppedDelegate();

	[SerializeField]
	private float offsetTime;

	[SerializeField]
	private float tweenTime = 2f;

	[SerializeField]
	private float waitTime = 0.35f;

	[SerializeField]
	private Transform[] targets;

	private AnimationCurve xPosition;

	private AnimationCurve yPosition;

	private AnimationCurve zPosition;

	private Rigidbody2D rigid;

	private Vector3 lastPosition;

	private bool wasMoving;

	public Action OnMoveStart;

	public event OnStoppedDelegate OnStopped;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		xPosition = new AnimationCurve
		{
			postWrapMode = WrapMode.Loop,
			preWrapMode = WrapMode.Loop
		};
		yPosition = new AnimationCurve
		{
			postWrapMode = WrapMode.Loop,
			preWrapMode = WrapMode.Loop
		};
		zPosition = new AnimationCurve
		{
			postWrapMode = WrapMode.Loop,
			preWrapMode = WrapMode.Loop
		};
		xPosition.AddKey(new Keyframe(0f, targets[0].position.x));
		yPosition.AddKey(new Keyframe(0f, targets[0].position.y));
		zPosition.AddKey(new Keyframe(0f, targets[0].position.z));
		float num = 0f;
		for (int i = 0; i < targets.Length; i++)
		{
			Vector3 position = targets[i].position;
			num += waitTime;
			xPosition.AddKey(new Keyframe(num, position.x, 0f, 0f));
			yPosition.AddKey(new Keyframe(num, position.y, 0f, 0f));
			zPosition.AddKey(new Keyframe(num, position.z, 0f, 0f));
			Vector3 position2 = targets[(i + 1) % targets.Length].position;
			num += tweenTime;
			xPosition.AddKey(new Keyframe(num, position2.x, 0f, 0f));
			yPosition.AddKey(new Keyframe(num, position2.y, 0f, 0f));
			zPosition.AddKey(new Keyframe(num, position2.z, 0f, 0f));
		}
	}

	public void Move(float time)
	{
		Vector3 vector = EvaluatePosition(time + offsetTime);
		bool flag = Mathf.Approximately(Vector3.Distance(vector, lastPosition), 0f);
		if (flag == wasMoving)
		{
			bool flag2 = !flag;
			if (flag)
			{
				this.OnStopped?.Invoke();
			}
			else
			{
				OnMoveStart?.Invoke();
			}
			wasMoving = flag2;
		}
		rigid.MovePosition(vector);
		lastPosition = vector;
	}

	private Vector3 EvaluatePosition(float time)
	{
		return new Vector3(xPosition.Evaluate(time), yPosition.Evaluate(time), zPosition.Evaluate(time));
	}

	private void OnDrawGizmosSelected()
	{
		if (targets != null && targets.Length != 0)
		{
			Vector3 from = targets[0].position;
			for (int i = 0; i < targets.Length; i++)
			{
				Transform transform = targets[i];
				Gizmos.DrawLine(from, transform.position);
				from = transform.position;
			}
			Gizmos.DrawLine(targets[0].position, targets[targets.Length - 1].position);
		}
	}
}
