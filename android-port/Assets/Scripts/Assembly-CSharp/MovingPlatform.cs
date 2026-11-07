using System;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
	[SerializeField]
	private float distance;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float normalizedStartPosition;

	[SerializeField]
	private float startDirection;

	[SerializeField]
	private bool useUnscaledTime;

	private float dir;

	private Vector3 startPos;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private Vector3 right;

	public Action OnTurn;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void MoveRigid(Vector3 position, bool useMovePosition)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
