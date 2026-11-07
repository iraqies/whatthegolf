using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class ExplosionBarrel : MonoBehaviour, IAudioEvent
{
	private Action<Collider, ExplosionBarrel> m_OnExplode;
	public UnityEvent OnExplodeEvent = new UnityEvent();
	public PlayClipOnAudioEvent ExplosionSFX;
	public float startCooldown = 0.1f;
	public bool canExplode = true;
	public ParticleSystem ps;
	public float impactThreshold = 1f;
	public float radius = 5f;
	public float power = 500f;
	public Renderer normalRender;
	public Renderer burnedRender;
	public bool screenShake = true;
	public float PlayerBlockDuration;
	public bool DestroyOnExplosion;
	public bool KeepOldVelocity;
	public float hitObjectExplosionForce = 500f;
	public Vector3 hitObjectExplosionForceModsMinRange;
	public Vector3 hitObjectExplosionForceModsMaxRange;
	public bool applyNormalExplosionToHitObject = true;
	public LayerMask ignoreLayers;
	public bool ExplodeOnOutOfBounds;
	public bool AddRandomAngularVelocity = true;

	private float ignoreTime;
	private float startTime;
	public bool didExplode;
	private float explosionTime;
	private bool shouldExplode;
	private Rigidbody rigid;
	private Collider[] nearbyColliders;
	private Rigidbody[] nearbyRigids;
	private float allowedExplodeTime;
	private bool initialized;
	private GolfBallController ball;

	public Action<Vector3> OnAudioEvent { get; set; }

	public event Action<Collider, ExplosionBarrel> OnExplode
	{
		add => m_OnExplode = (Action<Collider, ExplosionBarrel>)Delegate.Combine(m_OnExplode, value);
		remove => m_OnExplode = (Action<Collider, ExplosionBarrel>)Delegate.Remove(m_OnExplode, value);
	}

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		allowedExplodeTime = Time.time + startCooldown;
		initialized = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (didExplode || !canExplode || Time.time < allowedExplodeTime) return;
		if (collision != null && collision.relativeVelocity.magnitude >= impactThreshold)
			Explode(collision.collider);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (didExplode || !canExplode || Time.time < allowedExplodeTime) return;
		if (other != null && (other.GetComponentInParent<GolfBallController>() != null || other.CompareTag("Player") || other.CompareTag("Ball")))
			Explode(other);
	}

	private void Update()
	{
		if (shouldExplode && !didExplode && Time.time >= explosionTime)
			Explode(null);
	}

	public void SetExplosionTimer(float delay)
	{
		shouldExplode = true;
		explosionTime = Time.time + delay;
	}

	public void CanExplode() => canExplode = true;

	public void Explode(Collider col = null) => Explode(Vector3.up, col);

	private void Explode(Vector3 normal, Collider col = null)
	{
		if (didExplode) return;
		didExplode = true;
		if (ps != null) ps.Play();
		if (normalRender != null && burnedRender != null)
		{
			normalRender.enabled = false;
			burnedRender.enabled = true;
		}
		float r = radius > 0f ? radius : 5f;
		float f = power > 0f ? power : 400f;
		foreach (var hit in Physics.OverlapSphere(transform.position, r))
		{
			var rb = hit.attachedRigidbody;
			if (rb != null && !rb.isKinematic)
				rb.AddExplosionForce(f, transform.position, r, 1f, ForceMode.Impulse);
		}
		OnAudioEvent?.Invoke(transform.position);
		OnExplodeEvent?.Invoke();
		m_OnExplode?.Invoke(col, this);
		if (DestroyOnExplosion)
			gameObject.SetActive(false);
	}

	public void Reset()
	{
		didExplode = false;
		shouldExplode = false;
		if (normalRender != null) normalRender.enabled = true;
		if (burnedRender != null) burnedRender.enabled = false;
		gameObject.SetActive(true);
	}

	private void OnDrawGizmosSelected() { }
}
