using UnityEngine;

public class Asteroid : MonoBehaviour
{
	public int Health;

	public ParticleSystem BreakParticles;

	public Sprite[] PossibleSprites;

	public Transform[] SmallerAsteroidSpawnpoints;

	public GameObject AsteroidPrefab;

	public bool CarriesFlag;

	public float ExplosionForce = 10f;

	private int explosionTicks;

	private int hitTicks;

	private bool exploding;

	private Rigidbody2D rigidbody;

	protected Vector3 parentAsteroidPosition;

	public bool hit;

	public SpriteRenderer HitRenderer;

	private float hitScale = 1.12f;

	private void Awake()
	{
		SpriteRenderer component = GetComponent<SpriteRenderer>();
		if (PossibleSprites != null && PossibleSprites.Length != 0 && component != null)
		{
			component.sprite = PossibleSprites[Random.Range(0, PossibleSprites.Length)];
		}
		rigidbody = GetComponent<Rigidbody2D>();
		if (Health <= 0)
		{
			Health = Random.Range(2, 3);
		}
		base.transform.localScale = Vector3.one * Health;
		if (rigidbody != null)
		{
			Vector2 insideUnitCircle = Random.onUnitSphere;
			rigidbody.velocity = insideUnitCircle * Random.Range(0.1f, 0.5f);
			rigidbody.angularVelocity = Random.Range(-25f, 25f);
		}
	}

	public void Break()
	{
		if (BreakParticles != null)
		{
			BreakParticles.Emit(Random.Range(Health * 3, Health * 5));
			BreakParticles.transform.parent = null;
			Object.Destroy(BreakParticles.gameObject, 1f);
		}
		if (CarriesFlag)
		{
			return;
		}
		if (Health != 1 && SmallerAsteroidSpawnpoints != null && AsteroidPrefab != null)
		{
			for (int i = 0; i < SmallerAsteroidSpawnpoints.Length; i++)
			{
				Transform transform = SmallerAsteroidSpawnpoints[i];
				if (transform == null)
				{
					continue;
				}
				GameObject gameObject = Object.Instantiate(AsteroidPrefab, transform.position, Quaternion.identity);
				if (gameObject != null)
				{
					Asteroid component = gameObject.GetComponent<Asteroid>();
					if (component != null)
					{
						component.Health = Health - 1;
						component.parentAsteroidPosition = base.transform.position;
						component.exploding = true;
					}
					gameObject.transform.localScale = Vector3.one * (Health - 1);
				}
			}
		}
		Object.Destroy(base.gameObject);
	}

	private void Update()
	{
		if (exploding && rigidbody != null)
		{
			Vector2 force = (base.transform.position - parentAsteroidPosition).normalized;
			rigidbody.AddForceAtPosition(force, base.transform.position, ForceMode2D.Impulse);
			explosionTicks++;
		}
		if (explosionTicks >= 5)
		{
			exploding = false;
		}
		if (hit && HitRenderer != null)
		{
			HitRenderer.gameObject.SetActive(true);
			HitRenderer.transform.localScale = Vector3.one * hitScale;
			hitTicks++;
			hitScale += 0.1f;
		}
		if (hitTicks >= 5)
		{
			hit = false;
			Break();
		}
	}
}
