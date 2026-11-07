using System;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class BoardgameGolfer : MonoBehaviour
{
	[Serializable]
	public struct DiceSideToActionPair
	{
		public Vector3 axis;

		public bool onlyIfShot;

		public UnityEvent callback;
	}

	public List<Transform> targets;

	public List<GameObject> targetTiles;

	public Transform endTarget;

	public Transform bounceTarget;

	public int endTargetIndex;

	private int currentIndex;

	private int nextIndex;

	private int targetIndex;

	public GolfBallController dice;

	private Rigidbody diceRigid;

	private bool hasBeenShot;

	private float timer;

	public float CheckTimer;

	public float SleepThreshold;

	public float DotThreshold;

	private Vector3 startPosition;

	public List<DiceSideToActionPair> sideToActionMap;

	private Rigidbody rb;

	private Transform t;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float moveHeight;

	[SerializeField]
	private AnimationCurve moveHeightCurve;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float collisionExtraPush;

	public LayerMask groundLayer;

	private Vector3 startPos;

	private Quaternion startRot;

	[SerializeField]
	private ParticleSystem particleSystem;

	[SerializeField]
	private PropRain hotdogRain;

	private bool disabledByCollision;

	private float startTime;

	[SerializeField]
	private int particleCount;

	[SerializeField]
	private float maxHotdogDestroyAngle;

	[SerializeField]
	private float maxCollisionDisableAngle;

	[SerializeField]
	private float rotationCheckerRadius;

	[SerializeField]
	private Transform rotationCheckerCenter;

	private Collider[] rotationCheckResults;

	[SerializeField]
	private float respawnYOffset;

	[SerializeField]
	private BoardgameGolfer other;

	public List<Transform> alternativeTargets;

	private bool reachedNext;

	public int CurrentIndex => 0;

	public int NextIndex => 0;

	public int TargetIndex => 0;

	private bool isMoving => false;

	private void Start()
	{
	}

	private void Dice_OnShoot(Vector3 dir)
	{
	}

	private void Dice_OnReset()
	{
	}

	public void MovePiece(int value)
	{
	}

	public void RainHotdogs(int index)
	{
	}

	public void StopHotdogs()
	{
	}

	private void CheckDiceState()
	{
	}

	private void FixedUpdate()
	{
	}

	private Transform GetNextNode()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void ResetOnRespawn()
	{
	}

	public void OutOfBounds()
	{
	}
}
