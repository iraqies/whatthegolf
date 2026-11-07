using System;
using System.Collections.Generic;
using UnityEngine;

public class CarAgent : MonoBehaviour
{
	public float Speed;

	public float Gravity;

	public float RotateSpeed;

	public LayerMask IgnoreLayers;

	public LayerMask GroundLayer;

	public float unlockedForce;

	public float groundDist;

	public bool startUnlocked;

	public List<string> ResetTags;

	protected Rigidbody rigid;

	protected TrafficController.TrafficPoint _currentPath;

	private TrafficController trafficController;

	private TrafficController.TrafficPoint trafficPoint;

	public Action _onOutOfBounds;

	public Action _onCarFallingOffSide;

	protected Action _onCarCrashed;

	public Action _onCarSpeeding;

	protected Transform _currentGoal;

	protected bool isLocked;

	protected Vector3 smoothedNormal;

	protected float nonGroundTime;

	protected bool hasBeenFlat;

	protected Vector3 smoothedFlatForward;

	protected bool isFalling;

	protected float startLockTime;

	private bool isSpeedingUp;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Iniitialize(Vector3 position, Vector3 forward, TrafficController aTrafficController, TrafficController.TrafficPoint point)
	{
	}

	protected Vector3 GetNormal()
	{
		return default;
	}

	protected virtual void Unlock()
	{
	}

	protected bool IsGrounded()
	{
		return false;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	protected virtual void FixedUpdate()
	{
	}
}
