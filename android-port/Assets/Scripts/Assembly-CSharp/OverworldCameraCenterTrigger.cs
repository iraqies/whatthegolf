using System.Collections;
using UnityEngine;

public class OverworldCameraCenterTrigger : MonoBehaviour
{
	public enum BlendType
	{
		distanceFromCollider = 0,
		movementInCollider = 1,
		distanceFromPoint = 2
	}

	public OverworldCameraSettings inSettings;

	public BlendType blendType;

	public float blendDistance;

	public Transform blendPoint;

	public bool ignoreEndBall;

	public float delayedExitIfNotActive;

	private Collider2D col;

	private bool isInside;

	private Vector3 lastPosition;

	private float moveDist;

	private Coroutine delayedExitRoutine;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
	}

	private void OnTriggerExit2D(Collider2D collider)
	{
	}

	private IEnumerator DelayedExitOut(float delay)
	{
		return null;
	}

	private bool IsEndBall()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void CheckIfBallIsInside()
	{
	}
}
