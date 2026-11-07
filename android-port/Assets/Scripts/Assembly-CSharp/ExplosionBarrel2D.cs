using System;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;

public class ExplosionBarrel2D : MonoBehaviour, IAudioEvent
{
	public bool canExplode;

	public ParticleSystem ps;

	public float impactThreshold;

	public float radius;

	public float power;

	public float extraUpPower;

	public Renderer normalRender;

	public Renderer burnedRender;

	public bool screenShake;

	public float PlayerBlockDuration;

	public bool DestroyOnExplosion;

	public LayerMask ExplosionTriggerLayers;

	[CompilerGenerated]
	private Action<Collider2D> m_OnExplode;

	public bool SetVelocityInsteadOfAddForce;

	public bool UseTrigger;

	private float ignoreTime;

	private float startTime;

	public bool didExplode;

	private float explosionTime;

	private bool shouldExplode;

	private Rigidbody2D rigid;

	private Collider2D[] nearbyColliders;

	private Rigidbody2D[] nearbyRigids;

	private bool initialized;

	public Explosion2D m_Explosion2D;

	public float ExplosionMagnitude;

	public bool OnlyActivatedByBall;

	public Action<Vector3> OnAudioEvent { get; set; }

	public event Action<Collider2D> OnExplode
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void Update()
	{
	}

	private void SetExplosionTimer(float delay)
	{
	}

	public void Explode(Collider2D col = null)
	{
	}

	private void Explode(Vector2 contact, Vector2 normal, Collider2D col = null)
	{
	}

	public void DestroyAfterExplosion()
	{
	}

	public void SetBurnedRenders()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void SendOnExplodeEvent()
	{
	}
}
