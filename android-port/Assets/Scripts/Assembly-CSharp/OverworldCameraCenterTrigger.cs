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
	public float blendDistance = 1f;
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
		col = GetComponent<Collider2D>();
	}

	private void Start()
	{
		CheckIfBallIsInside();
	}

	private void Update()
	{
		if (ignoreEndBall && IsEndBall())
			return;
		if (!isInside)
			return;
		if (!OverworldBallManager.HasInstance || OverworldBallManager.Instance == null || OverworldBallManager.Instance.Ball == null)
			return;

		var ball = OverworldBallManager.Instance.Ball;
		float pct = 0f;
		float distDenom = Mathf.Max(0.01f, blendDistance);

		if (blendType == BlendType.movementInCollider)
		{
			Vector3 delta = ball.transform.position - lastPosition;
			moveDist += delta.magnitude;
			pct = Mathf.Clamp01(moveDist / distDenom);
		}
		else if (blendType == BlendType.distanceFromPoint && blendPoint != null)
		{
			float dist = (ball.transform.position - blendPoint.position).magnitude;
			pct = Mathf.Clamp01(dist / distDenom);
		}
		else if (blendType == BlendType.distanceFromCollider && col != null && ball.rigidBody != null)
		{
			ColliderDistance2D cd = ball.rigidBody.Distance(col);
			float dist = Mathf.Abs((cd.pointA - cd.pointB).magnitude);
			pct = Mathf.Clamp01(dist / distDenom);
		}

		if (inSettings != null)
			inSettings.SetValue(pct);
		lastPosition = ball.transform.position;
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider == null) return;
		var ball = collider.GetComponentInParent<OverworldBall2D>();
		if (ball == null) return;
		if (ignoreEndBall && IsEndBall()) return;
		if (delayedExitRoutine != null)
		{
			StopCoroutine(delayedExitRoutine);
			delayedExitRoutine = null;
		}
		lastPosition = ball.transform.position;
		if (!isInside)
			moveDist = 0f;
		isInside = true;
	}

	private void OnTriggerExit2D(Collider2D collider)
	{
		if (collider == null) return;
		var ball = collider.GetComponentInParent<OverworldBall2D>();
		if (ball == null) return;
		if (delayedExitIfNotActive > 0f && ball.gameObject.activeInHierarchy && ball.enabled)
		{
			if (delayedExitRoutine != null)
				StopCoroutine(delayedExitRoutine);
			delayedExitRoutine = StartCoroutine(DelayedExitOut(delayedExitIfNotActive));
			return;
		}
		isInside = false;
		moveDist = 0f;
		if (ignoreEndBall && IsEndBall()) return;
		if (inSettings != null)
			inSettings.SetValue(0f);
	}

	private IEnumerator DelayedExitOut(float delay)
	{
		yield return new WaitForSeconds(delay);
		isInside = false;
		moveDist = 0f;
		if (!(ignoreEndBall && IsEndBall()) && inSettings != null)
			inSettings.SetValue(0f);
		delayedExitRoutine = null;
	}

	private bool IsEndBall()
	{
		return OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.currentShape == Transmogrif.BALLSHAPES.endball;
	}

	private void OnEnable()
	{
		CheckIfBallIsInside();
	}

	private void CheckIfBallIsInside()
	{
		if (!OverworldBallManager.HasInstance || OverworldBallManager.Instance == null || OverworldBallManager.Instance.Ball == null || col == null)
			return;
		if (col.OverlapPoint(OverworldBallManager.Instance.Ball.transform.position))
		{
			if (ignoreEndBall && IsEndBall())
				return;
			isInside = true;
			if (inSettings != null)
				inSettings.SetValue(1f);
			moveDist = blendDistance;
		}
	}
}
