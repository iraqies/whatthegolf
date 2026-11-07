using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
	public delegate void OnStoppedDelegate();

	[SerializeField]
	private float offsetTime;

	[SerializeField]
	private float tweenTime;

	[SerializeField]
	private float waitTime;

	[SerializeField]
	private Transform[] targets;

	private AnimationCurve xPosition;

	private AnimationCurve yPosition;

	private AnimationCurve zPosition;

	private Rigidbody2D rigid;

	private Vector3 lastPosition;

	private bool wasMoving;

	[CompilerGenerated]
	private OnStoppedDelegate m_OnStopped;

	public Action OnMoveStart;

	public event OnStoppedDelegate OnStopped
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Move(float time)
	{
	}

	private Vector3 EvaluatePosition(float time)
	{
		return default;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
