using System.Collections.Generic;
using Core;
using UnityEngine;

public class Confetti : MonoBehaviour
{
	public new Rigidbody2D rigidbody;

	public new Renderer renderer;

	public List<Material> materials;

	public float lifeTime = 20f;

	public Vector2 shootForceRange = new Vector2(2f, 35f);

	public float minVelocity = 1f;

	private float startTime;

	private float startDrag;

	private int triggerCount;

	private ConfettiPrevention currentTrigger;

	private float actualLifeTime;

	private Vector3 startScale = new Vector3(0.02332682f, 0.02017739f, 0.72521f);

	private float initialDrag = 1f;

	public int amount = 2;

	private static Confetti instance;

	public float randomPitch = 0.05f;

	public List<AudioClip> clips;

	public List<ParticleSystem> particles;

	private void Awake()
	{
		startScale = transform.localScale;
		if (rigidbody == null)
			rigidbody = GetComponent<Rigidbody2D>();
		if (renderer == null)
			renderer = GetComponent<Renderer>();
		if (rigidbody != null)
			initialDrag = rigidbody.drag;
	}

	private void OnEnable()
	{
		if (particles != null && particles.Count > 0)
			instance = this;
	}

	public void Initiate()
	{
		if (rigidbody == null)
			rigidbody = GetComponent<Rigidbody2D>();
		if (renderer == null)
			renderer = GetComponent<Renderer>();
		if (startScale.sqrMagnitude < 1e-6f)
			startScale = transform.localScale;

		startDrag = initialDrag > 0f ? initialDrag : 1f;
		actualLifeTime = lifeTime * Random.Range(0.9f, 1.1f);
		if (materials != null && materials.Count > 0 && renderer != null)
		{
			int idx = Random.Range(0, materials.Count);
			if (materials[idx] != null)
				renderer.sharedMaterial = materials[idx];
		}
		transform.eulerAngles = new Vector3(0f, 0f, Random.Range(-180f, 180f));
		if (rigidbody != null)
		{
			Vector3 dir = Random.onUnitSphere;
			float force = Random.Range(shootForceRange.x, shootForceRange.y);
			rigidbody.velocity = new Vector2(dir.x * force, dir.y * force);
			rigidbody.angularVelocity = Random.Range(-1f, 1f) * Random.Range(50f, 500f);
		}
		float scaleMult = Random.Range(0.4f, 1f);
		transform.localScale = startScale * scaleMult;
		startTime = Time.time;
		actualLifeTime += actualLifeTime * 0.25f;
		triggerCount = 0;
		currentTrigger = null;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		var prev = collision.gameObject.GetComponent<ConfettiPrevention>();
		if (prev != null)
		{
			currentTrigger = prev;
			triggerCount++;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		var prev = collision.gameObject.GetComponent<ConfettiPrevention>();
		if (prev != null)
		{
			triggerCount = Mathf.Max(0, triggerCount - 1);
		}
	}

	public void Kill()
	{
		gameObject.SetActive(false);
	}

	private void FixedUpdate()
	{
		if (rigidbody == null)
			return;
		if (triggerCount >= 1 && currentTrigger != null && currentTrigger.gameObject.activeInHierarchy)
		{
			Vector3 diff = transform.position - currentTrigger.transform.position;
			rigidbody.AddForce(new Vector2(diff.x, diff.y) * 30f * Time.fixedDeltaTime, ForceMode2D.Force);
			rigidbody.drag = startDrag * 8f;
		}
		if (rigidbody.velocity.magnitude < minVelocity && !rigidbody.IsSleeping())
		{
			rigidbody.velocity = Vector2.zero;
			rigidbody.drag = startDrag;
			rigidbody.Sleep();
		}
		if (Time.time > startTime + actualLifeTime)
		{
			gameObject.SetActive(false);
		}
	}

	public static void SpawnConfetti(Transform trans)
	{
		if (trans == null)
			return;
		var spawner = Object.FindObjectOfType<ConfettiSpawner>();
		if (spawner != null)
		{
			spawner.RemoteSpawn(trans.position, false);
			return;
		}
		if (instance != null)
		{
			instance.SpawnInternal(trans);
		}
	}

	private void SpawnInternal(Transform trans)
	{
		if (particles == null || trans == null) return;
		transform.position = trans.position + Vector3.up * 0.5f;
		int count = Mathf.Clamp(amount, 1, particles.Count);
		for (int i = 0; i < count; i++)
		{
			int idx = Random.Range(0, particles.Count);
			if (particles[idx] != null)
				particles[idx].Play();
		}
	}
}
