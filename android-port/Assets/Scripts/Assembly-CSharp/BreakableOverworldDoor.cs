using Audio;
using UnityEngine;

public class BreakableOverworldDoor : GolfBehaviour
{
	public AudioClipSettings sfxExplode;

	public ParticleSystem particles;

	public float minSpeedToBreak = 5f;

	[SerializeField]
	private OverworldButton2D buttonDoor;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		if (buttonDoor == null)
			buttonDoor = GetComponentInParent<OverworldButton2D>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var ball = other.GetComponentInParent<OverworldBall2D>();
		if (ball == null || ball.Velocity.magnitude < minSpeedToBreak)
			return;
		if (sfxExplode != null)
			sfxExplode.Play(transform.position);
		if (particles != null)
			particles.Play();
		if (buttonDoor == null)
			buttonDoor = GetComponentInParent<OverworldButton2D>();
		if (buttonDoor != null)
			buttonDoor.JustOpen(false);
	}
}
