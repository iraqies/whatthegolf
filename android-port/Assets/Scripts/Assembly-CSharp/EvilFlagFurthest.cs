using System.Collections.Generic;
using Core;
using UnityEngine;

public class EvilFlagFurthest : MonoBehaviour
{
	public enum FlagSelectionEnum
	{
		Closest = 0,
		Middle = 1,
		Furthest = 2
	}

	public List<Transform> positions;

	public float velocity;

	public bool jumpingFlag;

	public GolfBallController ball;

	public FlagSelectionEnum FlagSelection;

	private Rigidbody rigidbody;

	private Transform currentTarget;

	private Vector3 currentPos;

	private Vector3 midPoint;

	private bool ballShot;

	private float count;

	private void Start()
	{
	}

	private void Ball_OnPreShoot(Vector3 aim)
	{
	}

	private void Ball_OnShoot(Vector3 direction)
	{
	}

	private void FixedUpdate()
	{
	}
}
