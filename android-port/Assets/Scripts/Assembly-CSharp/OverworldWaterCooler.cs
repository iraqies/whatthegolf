using Audio;
using UnityEngine;

public class OverworldWaterCooler : MonoBehaviour
{
	public RandomAudioClips hitSfx;

	public ParticleSystem particles;

	private float nextHitSound;

	private Collider2D col;

	private Coroutine lastRoutine;

	private Quaternion baseRotation;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
