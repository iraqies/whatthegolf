using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;

public class ExplosionBarrel2D : MonoBehaviour, IAudioEvent
{
	public bool canExplode = true;

	public ParticleSystem ps;

	public float impactThreshold = 1f;

	public float radius = 5f;

	public float power = 15f;

	public float extraUpPower = 3f;

	public Renderer normalRender;

	public Renderer burnedRender;

	public bool screenShake = true;

	public float PlayerBlockDuration = 0.25f;

	public bool DestroyOnExplosion;

	public LayerMask ExplosionTriggerLayers = -1;

	[CompilerGenerated]
	private Action<Collider2D> m_OnExplode;

	public bool SetVelocityInsteadOfAddForce;

	public bool UseTrigger;

	private float ignoreTime = 0.2f;

	private float startTime;

	public bool didExplode;

	private float explosionTime;

	private bool shouldExplode;

	private Rigidbody2D rigid;

	private Collider2D[] nearbyColliders;

	private Rigidbody2D[] nearbyRigids;

	private bool initialized;

	public Explosion2D m_Explosion2D;

	public float ExplosionMagnitude = 1f;

	public bool OnlyActivatedByBall;

	public Action<Vector3> OnAudioEvent { get; set; }

	public event Action<Collider2D> OnExplode
	{
		[CompilerGenerated]
		add
		{
			m_OnExplode = (Action<Collider2D>)Delegate.Combine(m_OnExplode, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnExplode = (Action<Collider2D>)Delegate.Remove(m_OnExplode, value);
		}
	}

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		startTime = Time.time;
		if (burnedRender != null)
		{
			burnedRender.enabled = false;
		}
		initialized = true;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!UseTrigger || !canExplode || didExplode || other == null || Time.time - startTime < ignoreTime)
		{
			return;
		}
		if (OnlyActivatedByBall && !other.CompareTag("Player") && other.GetComponentInParent<GolfBallController>() == null)
		{
			return;
		}
		if (((1 << other.gameObject.layer) & ExplosionTriggerLayers) != 0)
		{
			Explode(other);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (UseTrigger || !canExplode || didExplode || collision == null || Time.time - startTime < ignoreTime)
		{
			return;
		}
		if (OnlyActivatedByBall && !collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponentInParent<GolfBallController>() == null)
		{
			return;
		}
		if (collision.relativeVelocity.magnitude >= impactThreshold)
		{
			Vector2 contact = collision.contactCount > 0 ? collision.GetContact(0).point : (Vector2)transform.position;
			Vector2 normal = collision.contactCount > 0 ? collision.GetContact(0).normal : Vector2.up;
			Explode(contact, normal, collision.collider);
		}
	}

	private void Update()
	{
		if (shouldExplode && !didExplode && Time.time >= explosionTime)
		{
			Explode(null);
		}
	}

	private void SetExplosionTimer(float delay)
	{
		if (!didExplode && !shouldExplode)
		{
			shouldExplode = true;
			explosionTime = Time.time + delay;
		}
	}

	public void Explode(Collider2D col = null)
	{
		Explode(transform.position, Vector2.up, col);
	}

	private void Explode(Vector2 contact, Vector2 normal, Collider2D col = null)
	{
		if (didExplode || !canExplode)
		{
			return;
		}
		didExplode = true;
		shouldExplode = false;
		SetBurnedRenders();
		if (ps != null)
		{
			ps.Play();
		}
		if (m_Explosion2D != null)
		{
			m_Explosion2D.Explode(ExplosionMagnitude);
		}
		Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius);
		for (int i = 0; i < hits.Length; i++)
		{
			Collider2D hit = hits[i];
			if (hit == null || hit.gameObject == gameObject)
			{
				continue;
			}
			ExplosionBarrel2D otherBarrel = hit.GetComponent<ExplosionBarrel2D>();
			if (otherBarrel != null && !otherBarrel.didExplode)
			{
				otherBarrel.SetExplosionTimer(0.1f);
			}
			Rigidbody2D rb = hit.attachedRigidbody;
			if (rb != null && rb != rigid)
			{
				Vector2 diff = rb.position - (Vector2)transform.position;
				float dist = Mathf.Max(0.25f, diff.magnitude);
				float falloff = Mathf.Clamp01(1f - dist / Mathf.Max(0.5f, radius));
				Vector2 impulse = diff.normalized * (power * falloff) + Vector2.up * (extraUpPower * falloff);
				if (SetVelocityInsteadOfAddForce)
				{
					rb.velocity = impulse;
				}
				else
				{
					rb.AddForce(impulse, ForceMode2D.Impulse);
				}
			}
		}
		OnAudioEvent?.Invoke(transform.position);
		m_OnExplode?.Invoke(col);
		if (DestroyOnExplosion)
		{
			DestroyAfterExplosion();
		}
	}

	public void DestroyAfterExplosion()
	{
		gameObject.SetActive(false);
	}

	public void SetBurnedRenders()
	{
		if (normalRender != null)
		{
			normalRender.enabled = false;
		}
		if (burnedRender != null)
		{
			burnedRender.enabled = true;
		}
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void SendOnExplodeEvent()
	{
		OnAudioEvent?.Invoke(transform.position);
	}
}
