using Core;
using UnityEngine;

public class EvilFlagAvoidAim : MonoBehaviour
{
	public float velocity;

	public float distance;

	public float groundCheckDist;

	private float changeDirChance;

	public GolfBallController ball;

	public Collider trigger;

	private Rigidbody rigidbody;

	private Vector3 currentTarget;

	private float lastDir;

	private bool done;

	private bool wasAimTouching;

	private void Start()
	{
	}

	private void Ball_OnAimUpdate(Vector3 aimDir, bool isCancelled)
	{
	}

	private void FixedUpdate()
	{
	}
}
