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
		var otherRb = collision.attachedRigidbody ?? collision.GetComponent<Rigidbody2D>();
		if (otherRb == null || otherRb.velocity.magnitude < velocityThreshold)
			return;
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
		if (rigid != null)
		{
			rigid.AddForce(otherRb.velocity * pushForce, ForceMode2D.Impulse);
			rigid.AddTorque(Random.Range(-pushForce, pushForce), ForceMode2D.Impulse);
		}
		if (hitSfx != null)
			hitSfx.PlayRandomClip(transform, Mathf.Clamp01(otherRb.velocity.magnitude / 10f), 1f);
		nextPush = Time.time + 0.05f;
		lastOtherCol = collision;
	}

	private void Update()
	{
		if (rigid != null && !rigid.IsSleeping() && rigid.velocity.sqrMagnitude < sleepThreshold * sleepThreshold)
		{
			rigid.velocity = Vector2.zero;
			rigid.angularVelocity = 0f;
			rigid.Sleep();
		}
	}
}
