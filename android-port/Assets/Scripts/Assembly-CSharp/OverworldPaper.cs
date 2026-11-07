using Audio;
using UnityEngine;

public class OverworldPaper : GolfBehaviour
{
	public float pushForce;

	public float sleepThreshold;

	public float velocityThreshold;

	public RandomAudioClips hitSfx;

	[SerializeField]
	private Collider2D col;

	[SerializeField]
	private Rigidbody2D rigid;

	private float nextPush;

	private Collider2D lastOtherCol;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void Update()
	{
	}
}
