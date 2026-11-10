using Audio;
using UnityEngine;

public class OverworldPaper : GolfBehaviour
{
	public float pushForce = 5f;
	public float sleepThreshold = 0.05f;
	public float velocityThreshold = 0.2f;
	public RandomAudioClips hitSfx;
	[SerializeField] private Collider2D col;
	[SerializeField] private Rigidbody2D rigid;
	private float nextPush;
	private Collider2D lastOtherCol;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (col == null) col = GetComponent<Collider2D>();
		if (rigid == null) rigid = GetComponent<Rigidbody2D>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null || Time.time < nextPush)
			return;
		Rigidbody2D otherRb = collision.GetComponent<Rigidbody2D>();
		if (otherRb == null)
			otherRb = collision.attachedRigidbody;
		if (otherRb == null)
			return;
		float mag = otherRb.velocity.magnitude;
		if (mag <= velocityThreshold)
			return;

		nextPush = Time.time + 1f;
		if (col == null)
			col = GetComponent<Collider2D>();
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();

		Collider2D otherCol = collision.GetComponent<Collider2D>();
		if (otherCol == null)
			otherCol = collision;
		lastOtherCol = otherCol;
		if (col != null && lastOtherCol != null)
			Physics2D.IgnoreCollision(col, lastOtherCol, true);
		if (col != null)
			col.isTrigger = false;

		if (hitSfx != null && AudioManager.Instance != null)
			hitSfx.PlayRandomClip(transform.position);

		if (rigid != null)
		{
			Vector2 dir = otherRb.velocity.normalized;
			float forceScale = pushForce * Mathf.Clamp01(mag / 10f);
			Vector2 force = dir * forceScale;
			Vector2 hitPos = collision.transform.position;
			rigid.AddForceAtPosition(force, hitPos);
		}
	}

	private void Update()
	{
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
		if (rigid == null || rigid.IsSleeping())
			return;
		if (rigid.velocity.magnitude < sleepThreshold)
		{
			if (col == null)
				col = GetComponent<Collider2D>();
			if (col != null)
				col.isTrigger = true;
			rigid.Sleep();
			if (lastOtherCol != null && col != null)
			{
				Physics2D.IgnoreCollision(col, lastOtherCol, false);
				lastOtherCol = null;
			}
		}
	}
}
