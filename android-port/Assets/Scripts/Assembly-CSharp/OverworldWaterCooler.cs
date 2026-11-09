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
		baseRotation = transform.rotation;
		col = GetComponent<Collider2D>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null) return;
		float mag = collision.relativeVelocity.magnitude;
		float vol = Mathf.Clamp01(mag / 10f);
		if (Time.time > nextHitSound)
		{
			if (hitSfx != null)
				hitSfx.PlayRandomClip(transform, vol, 1f);
			nextHitSound = Time.time + 0.05f;
		}
		if (particles != null)
		{
			var main = particles.main;
			StartCoroutine(pTween.To(1f, 3f, 1f, t => main.simulationSpeed = t));
		}
		if (lastRoutine != null)
			StopCoroutine(lastRoutine);
		lastRoutine = StartCoroutine(pTween.To(0.25f, 0f, 1f, t =>
		{
			Vector3 euler = baseRotation.eulerAngles;
			transform.rotation = Quaternion.Euler(0f, 0f, euler.z + Mathf.Sin(t * Mathf.PI * 4f) * (1f - t) * 4f);
		}).Then(() =>
		{
			transform.rotation = baseRotation;
		}));
	}
}
