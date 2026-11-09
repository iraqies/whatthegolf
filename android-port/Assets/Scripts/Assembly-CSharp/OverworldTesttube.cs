using Audio;
using UnityEngine;

public class OverworldTesttube : MonoBehaviour
{
	public Transform floatyObject;
	public float floatyDistance = 0.2f;
	public float floatyRotation = 15f;
	public bool isRotatingSineWave;
	public RandomAudioClips hitSfx;
	public ParticleSystem particles;
	private float nextHitSound;
	private Collider2D col;
	private Coroutine lastRoutine;
	private Vector3 baseFloatyPosition;
	private Quaternion baseFloatyRotation;
	private float floatTime;

	private void Awake()
	{
		if (floatyObject != null)
		{
			baseFloatyPosition = floatyObject.position;
			baseFloatyRotation = floatyObject.rotation;
		}
		col = GetComponent<Collider2D>();
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void Update()
	{
		if (floatyObject == null) return;
		float speed = 1f;
		if (particles != null)
			speed = particles.main.simulationSpeed;
		floatTime += Time.deltaTime * speed;
		floatyObject.position = baseFloatyPosition + Vector3.up * (Mathf.Sin(floatTime) * floatyDistance);
		if (isRotatingSineWave)
		{
			floatyObject.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(floatTime * 0.5f) * floatyRotation) * Quaternion.Inverse(baseFloatyRotation);
		}
		else
		{
			floatyObject.Rotate(0f, 0f, floatyRotation * Time.deltaTime);
		}
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
			transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Sin(t * Mathf.PI * 4f) * (1f - t) * 4f);
		}).Then(() =>
		{
			transform.rotation = Quaternion.identity;
		}));
	}
}
