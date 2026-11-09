using System;
using Audio;
using CameraStack;
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
	public float impactThreshold = 5f;
	public float radius = 10f;
	public float power = 10f;
	public Renderer normalRender;
	public Renderer burnedRender;
	public bool screenShake = true;
	public float PlayerBlockDuration = 0.5f;
	public bool DestroyOnExplosion;
	public bool KeepOldVelocity = true;
	public float hitObjectExplosionForce = 30f;
	public Vector3 hitObjectExplosionForceModsMinRange = new Vector3(0f, 2.9f, 0f);
	public Vector3 hitObjectExplosionForceModsMaxRange = new Vector3(0f, 2.9f, 0f);
	public bool applyNormalExplosionToHitObject;
	public LayerMask ignoreLayers;
	public bool ExplodeOnOutOfBounds = true;
	public bool AddRandomAngularVelocity;

	private float ignoreTime = 0.1f;
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
		if (initialized) return;
		startTime = Time.time;
		rigid = GetComponent<Rigidbody>();
		if (!DestroyOnExplosion)
		{
			if (rigid != null) rigid.maxAngularVelocity = 15f;
			if (burnedRender != null) burnedRender.enabled = false;
		}
		allowedExplodeTime = Time.time + startCooldown;
		nearbyColliders = new Collider[200];
		nearbyRigids = new Rigidbody[30];
		ball = FindObjectOfType<GolfBallController>();
		initialized = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.collider == null) return;
		int layerBit = 1 << collision.collider.gameObject.layer;
		if ((ignoreLayers.value & layerBit) != 0) return;
		if (collision.relativeVelocity.magnitude <= impactThreshold) return;
		if (Time.time <= startTime + ignoreTime) return;
		var contacts = collision.contacts;
		Vector3 normal = (contacts != null && contacts.Length > 0) ? contacts[0].normal : Vector3.up;
		Explode(normal, collision.collider);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (other.CompareTag("OutOfBounds") || other.CompareTag("BoundsFail") || other.CompareTag("KillZone"))
		{
			if (ExplodeOnOutOfBounds)
				Explode(Vector3.up, null);
		}
	}

	private void Update()
	{
		if (shouldExplode && Time.time >= explosionTime)
		{
			shouldExplode = false;
			Explode(Vector3.zero, null);
		}
	}

	public void SetExplosionTimer(float delay)
	{
		shouldExplode = true;
		explosionTime = Time.time + delay;
	}

	public void CanExplode() => canExplode = true;

	public void Explode(Collider col = null) => Explode(Vector3.zero, col);

	private void Explode(Vector3 normal, Collider col = null)
	{
		if (didExplode || !canExplode) return;
		if (startCooldown > 0f && Time.time < allowedExplodeTime) return;
		if (!initialized) Start();

		Rigidbody hitRb = (col != null) ? col.attachedRigidbody : null;
		if (hitRb != null)
		{
			Vector3 negNorm = (-normal).normalized;
			float t = Mathf.Clamp01(UnityEngine.Random.value);
			Vector3 mod = Vector3.Lerp(hitObjectExplosionForceModsMinRange, hitObjectExplosionForceModsMaxRange, t);
			Vector3 dir = negNorm + mod;
			hitRb.velocity *= 0.1f;
			hitRb.AddForce(dir * hitObjectExplosionForce, ForceMode.Impulse);
			if (AddRandomAngularVelocity)
				hitRb.AddTorque(UnityEngine.Random.onUnitSphere * hitObjectExplosionForce);
			var explodable = hitRb.GetComponent<IExplodable>();
			explodable?.OnExplode();
			if (ball != null && ball.gameObject == hitRb.gameObject)
				ball.TimedBlockShot(PlayerBlockDuration);
		}

		if (!DestroyOnExplosion)
		{
			if (burnedRender != null) burnedRender.enabled = true;
			if (normalRender != null) normalRender.enabled = false;
		}

		if (ps != null) ps.Play(true);
		m_OnExplode?.Invoke(col, this);
		OnExplodeEvent?.Invoke();
		OnAudioEvent?.Invoke(transform.position);
		didExplode = true;

		int count = Physics.OverlapSphereNonAlloc(transform.position, radius, nearbyColliders);
		for (int i = 0; i < nearbyRigids.Length; i++)
			nearbyRigids[i] = null;

		int rigidCount = 0;
		for (int i = 0; i < count && rigidCount < nearbyRigids.Length; i++)
		{
			var c = nearbyColliders[i];
			if (c == null) continue;
			var rb = c.attachedRigidbody;
			if (rb == null) continue;
			if (!applyNormalExplosionToHitObject && rb == hitRb)
				continue;

			bool alreadyAdded = false;
			for (int j = 0; j < rigidCount; j++)
			{
				if (nearbyRigids[j] == rb)
				{
					alreadyAdded = true;
					break;
				}
			}
			if (alreadyAdded) continue;

			nearbyRigids[rigidCount++] = rb;
			if (!KeepOldVelocity)
			{
				Vector3 v = rb.velocity;
				rb.velocity = new Vector3(v.x * 0.9f, v.y * 0.9f * 0.5f, v.z * 0.9f);
			}
			rb.AddExplosionForce(power, transform.position, radius, 2.15f);
			var explodable = rb.GetComponent<IExplodable>();
			explodable?.OnExplode();
			if (ball != null && rb.gameObject == ball.gameObject)
				ball.TimedBlockShot(PlayerBlockDuration);
		}

		if (screenShake && CameraManager.Instance != null)
			CameraManager.Instance.Shake(0.5f, 20f, 2f);

		if (rigid != null && !rigid.isKinematic)
		{
			rigid.AddForce(Vector3.up * 6f + UnityEngine.Random.onUnitSphere * 0.7f);
			rigid.AddTorque(UnityEngine.Random.onUnitSphere * 300f, ForceMode.Impulse);
		}

		if (DestroyOnExplosion)
		{
			if (ps != null)
			{
				ps.transform.SetParent(null);
				var main = ps.main;
				main.stopAction = ParticleSystemStopAction.Destroy;
			}
			Destroy(gameObject);
		}
	}

	public void Reset()
	{
		if (burnedRender != null) burnedRender.enabled = false;
		if (normalRender != null) normalRender.enabled = true;
		didExplode = false;
		shouldExplode = false;
	}

	private void OnDrawGizmosSelected() { }
}
