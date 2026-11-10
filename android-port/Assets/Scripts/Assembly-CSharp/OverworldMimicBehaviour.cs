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
		startingPosition = base.transform.position;
		rigidbody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	private void Reset()
	{
		StopAllCoroutines();
		playerTarget = null;
		if (animator != null)
		{
			animator.SetTrigger("Reset");
		}
		if (rigidbody2D != null)
		{
			rigidbody2D.MovePosition(startingPosition);
			rigidbody2D.velocity = Vector2.zero;
		}
	}

	private void Update()
	{
		if ((bool)playerTarget)
		{
			float num = Vector3.Distance(playerTarget.position, base.transform.position);
			if (num > ResetRange)
			{
				Reset();
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!playerTarget)
		{
			StartCoroutine(StartFollowAfterDelay(collision));
			if (animator != null)
			{
				animator.SetTrigger("Open");
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.blue;
	}

	private IEnumerator StartFollowAfterDelay(Collision2D collision)
	{
		yield return new WaitForSeconds(0.5f);
		if (collision != null)
		{
			playerTarget = collision.transform;
		}
		while (true)
		{
			if (animator != null)
			{
				animator.SetTrigger("Jump");
			}
			if (playerTarget != null && rigidbody2D != null)
			{
				Vector3 normalized = (playerTarget.position - base.transform.position).normalized;
				rigidbody2D.AddForce(new Vector2(normalized.x * FollowStrength, normalized.y * FollowStrength), ForceMode2D.Impulse);
			}
			yield return new WaitForSeconds(DelayBetweenShots);
		}
	}

	public OverworldMimicBehaviour()
	{
		DelayBetweenShots = 1f;
		FollowStrength = 1f;
		ResetRange = 100f;
	}
}
