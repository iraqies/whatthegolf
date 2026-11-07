using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class SynchronizedSwimmerAI : MonoBehaviour
{
	[SerializeField]
	private SwimmerShooter shooter;

	[SerializeField]
	private List<Vector3> sequence;

	[SerializeField]
	public float delayBetweenMoves;

	private int currentMoveIndex;

	private float lastMoveTime;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private ShootArrow shootArrow;

	private float inputTarget;

	private GolfBallController controller;

	private float currentAnimVel;

	[SerializeField]
	private float shootArrowAnimSmoothTime;

	[CompilerGenerated]
	private Action<SynchronizedSwimmerAI> m_OnMoveTargetReached;

	private bool raisedEventForLastMove;

	public event Action<SynchronizedSwimmerAI> OnMoveTargetReached
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

	private void Start()
	{
	}

	private void Update()
	{
	}
}
