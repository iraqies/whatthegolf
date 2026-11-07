using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spectator : MonoBehaviour
{
	public Transform LookingAt;

	public Animator Animator;

	public float ViewDistance;

	public float CheckInterval;

	public Transform ViewOriginOverride;

	public Transform HeadJointTransform;

	[SerializeField]
	private float heldObjectActiveChance;

	public GameObject HeldObject;

	public Transform[] DummyLookTargets;

	public float DummyLookTimerMin;

	public float DummyLookTimerMax;

	public float DummyLookCooldownMin;

	public float DummyLookCooldownMax;

	public float HeadRotationSpeedMin;

	public float HeadRotationSpeedMax;

	public float HeadRotationSpeed;

	public Transform CurrentLookAtTarget;

	[CompilerGenerated]
	private Action m_OnSpectatorSeeingTarget;

	[CompilerGenerated]
	private Action m_OnSpectatorLosingTarget;

	public bool canSeePlayer { get; private set; }

	public event Action OnSpectatorSeeingTarget
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

	public event Action OnSpectatorLosingTarget
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

	private IEnumerator Start()
	{
		return null;
	}

	public void StopHoldingThing()
	{
	}

	private IEnumerator LookAtRoutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
