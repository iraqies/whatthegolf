using UnityEngine;

public class Asteroid : MonoBehaviour
{
	public int Health;

	public ParticleSystem BreakParticles;

	public Sprite[] PossibleSprites;

	public Transform[] SmallerAsteroidSpawnpoints;

	public GameObject AsteroidPrefab;

	public bool CarriesFlag;

	public float ExplosionForce;

	private int explosionTicks;

	private int hitTicks;

	private bool exploding;

	private Rigidbody2D rigidbody;

	protected Vector3 parentAsteroidPosition;

	public bool hit;

	public SpriteRenderer HitRenderer;

	private float hitScale;

	private void Awake()
	{
	}

	public void Break()
	{
	}

	private void Update()
	{
	}
}
