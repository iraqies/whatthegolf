using System.Collections;
using UnityEngine;

public class OverworldMimicBehaviour : MonoBehaviour
{
	public float DelayBetweenShots;

	public float FollowStrength;

	public float ResetRange;

	public Transform playerTarget;

	private Vector3 startingPosition;

	private Rigidbody2D rigidbody2D;

	private Animator animator;

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private IEnumerator StartFollowAfterDelay(Collision2D collision)
	{
		return null;
	}
}
