using System.Collections;
using Core;
using UnityEngine;

public class EvilFlagPanic : MonoBehaviour
{
	public Transform validAreaCenter;

	public float searchAreaMinRadius;

	public float searchAreaMaxRadius;

	public float velocity;

	public float changeDirChance;

	public float awayAngle1;

	public float awayAngle2;

	public int maxAttempts;

	public GolfBallController ball;

	private Rigidbody rigid;

	private Vector3 currentTarget;

	private void Awake()
	{
	}

	private void Ball_OnAimStart()
	{
	}

	private IEnumerator Behavior()
	{
		return null;
	}

	private Vector3 GetNewTarget(int maxAttempts)
	{
		return default;
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
