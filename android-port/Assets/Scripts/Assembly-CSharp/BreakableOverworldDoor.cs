using Audio;
using UnityEngine;

public class BreakableOverworldDoor : GolfBehaviour
{
	public AudioClipSettings sfxExplode;

	public ParticleSystem particles;

	public float minSpeedToBreak;

	[SerializeField]
	private OverworldButton2D buttonDoor;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
