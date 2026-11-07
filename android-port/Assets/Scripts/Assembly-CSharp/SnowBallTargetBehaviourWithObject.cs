using System;
using Audio;
using UnityEngine;

public class SnowBallTargetBehaviourWithObject : MonoBehaviour
{
	public Vector2 IdleTimeAtWayPoint;

	public Rigidbody Rigidbody;

	public float MoveSpeed;

	public float RotateSpeed;

	public Animator Animator;

	public Vector2 AnimatorSpeedRanges;

	public DollyCartController FollowTarget;

	public float SpeedMod;

	public float RotateAnimationSpeed;

	public Action<SnowBallTargetBehaviourWithObject> OnCollapsed;

	public AudioEventAsset sfxEventOnCollapse;

	public AudioEventAsset sfxOnSpeedup;

	private float idleTime;

	private float lastAnimatorSpeed;

	private Vector3 refVel;

	private float lastFrameDeltaTime;

	private bool hasCollapsed;

	private bool firstFrame;

	private Vector3 oldPos;

	private float targetVel;

	private Vector3 forward;

	public GameObject carriedObject;

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void LateUpdate()
	{
	}

	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		return false;
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
