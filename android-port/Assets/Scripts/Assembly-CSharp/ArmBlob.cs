using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ArmBlob : MonoBehaviour
{
	public List<Transform> throwTargets;

	public float pullForce;

	public float pushForce;

	public float isCloseThreshold;

	public float isCloseEnoughThreshold;

	public float isTooCloseThreshold;

	public Transform center;

	public Transform target;

	public bool debug;

	public Transform eyeLeft;

	public Transform eyeRight;

	public float eyeMaxMovement;

	public List<Transform> endpoints;

	public float maxDistance;

	public float raycastOffsetForFindingBall;

	[SerializeField]
	private LayerMask layerMask;

	public float extraDragWhilePulling;

	public float dragMinimumVelocity;

	public float multiplyOldVelocityBeforeThrowing;

	private Vector3 eyeLeftBase;

	private Vector3 eyeRightBase;

	private Vector3 lastBallPos;

	private float nextGrab;

	private bool wasGrabbing;

	private int nextTarget;

	private Rigidbody2D rigid;

	public Transform[] ClawLeft;

	public Transform[] ClawRight;

	public float ClawRotationOffset;

	private float clawPct;

	private float lastClawPct;

	public bool ignoreRaycast;

	private RaycastHit2D[] results;

	public AudioEventAsset throwSFX;

	public AudioEventAsset clawSFX;

	public float clawSFXCooldown;

	private float nextSFXTime;

	public bool isPulling { get; private set; }

	private void Start()
	{
	}

	private void NextRandomTarget()
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private void UpdateClaws(bool isClawed)
	{
	}

	private void Update()
	{
	}
}
