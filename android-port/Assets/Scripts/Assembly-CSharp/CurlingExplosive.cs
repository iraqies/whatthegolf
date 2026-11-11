using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class CurlingExplosive : MonoBehaviour, IAudioEvent
{
	public UnityEvent OnExplodeEvent;

	public PlayClipOnAudioEvent ExplosionSFX;

	public bool failOnExplode = true;

	public float startCooldown;

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

	public bool ExplodeOnOutOfBounds;

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

	public event Action<Collider, CurlingExplosive> OnExplode;

	private void Start()
	{
		if (initialized)
		{
			return;
		}
		startTime = Time.time;
		rigid = GetComponent<Rigidbody>();
		if (!DestroyOnExplosion)
		{
			if (rigid != null)
			{
				rigid.maxAngularVelocity = 15f;
			}
			if (burnedRender != null)
			{
				burnedRender.enabled = false;
			}
		}
		allowedExplodeTime = Time.time + startCooldown;
		nearbyColliders = new Collider[200];
		nearbyRigids = new Rigidbody[30];
		ball = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		initialized = true;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.collider == null)
		{
			return;
		}
		int value = ignoreLayers;
		if (value == (value | (1 << collision.collider.gameObject.layer)))
		{
			return;
		}
		if (collision.relativeVelocity.magnitude > impactThreshold && Time.time > startTime + ignoreTime && collision.contacts.Length > 0)
		{
			Explode(collision.contacts[0].normal, collision.collider);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
		{
			return;
		}
		if ((other.CompareTag("OutOfBounds") || other.CompareTag("OutOfBoundsReset") || other.CompareTag("OutOfBoundsReload")) && ExplodeOnOutOfBounds)
		{
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

	public void Explode(Collider col = null)
	{
		Explode(Vector3.zero, col);
	}

	private void Explode(Vector3 normal, Collider col = null)
	{
		if (didExplode || !canExplode || (startCooldown > 0f && Time.time < allowedExplodeTime))
		{
			return;
		}
		if (!initialized)
		{
			Start();
		}
		Rigidbody hitRigid = null;
		if (col != null && col.attachedRigidbody != null)
		{
			hitRigid = col.attachedRigidbody;
			Vector3 vector = -normal;
			vector.Normalize();
			float t = Mathf.Clamp01(UnityEngine.Random.value);
			Vector3 vector2 = new Vector3(
				hitObjectExplosionForceModsMinRange.x + (hitObjectExplosionForceModsMaxRange.x - hitObjectExplosionForceModsMinRange.x) * t,
				hitObjectExplosionForceModsMinRange.y + (hitObjectExplosionForceModsMaxRange.y - hitObjectExplosionForceModsMinRange.y) * t,
				hitObjectExplosionForceModsMinRange.z + (hitObjectExplosionForceModsMaxRange.z - hitObjectExplosionForceModsMinRange.z) * t);
			Vector3 vector3 = vector + vector2;
			hitRigid.velocity *= 0.1f;
			hitRigid.AddForce(vector3 * hitObjectExplosionForce, ForceMode.Impulse);
			if (AddRandomAngularVelocity)
			{
				hitRigid.AddTorque(UnityEngine.Random.onUnitSphere * hitObjectExplosionForce);
			}
			IExplodable component = hitRigid.GetComponent<IExplodable>();
			if (component != null)
			{
				component.OnExplode();
			}
			if (ball != null && ball.gameObject == hitRigid.gameObject)
			{
				ball.TimedBlockShot(PlayerBlockDuration);
			}
		}
		if (!DestroyOnExplosion)
		{
			if (burnedRender != null)
			{
				burnedRender.enabled = true;
			}
			if (normalRender != null)
			{
				normalRender.enabled = false;
			}
		}
		if (ps != null)
		{
			ps.Play(false);
		}
		this.OnExplode?.Invoke(col, this);
		if (OnExplodeEvent != null)
		{
			OnExplodeEvent.Invoke();
		}
		OnAudioEvent?.Invoke(base.transform.position);
		didExplode = true;
		Vector3 position = base.transform.position;
		int num = Physics.OverlapSphereNonAlloc(position, radius, nearbyColliders);
		for (int i = 0; i < nearbyRigids.Length; i++)
		{
			nearbyRigids[i] = null;
		}
		int num2 = 0;
		for (int j = 0; j < num && num2 < nearbyRigids.Length; j++)
		{
			Collider collider = nearbyColliders[j];
			if (collider == null)
			{
				continue;
			}
			Rigidbody attachedRigidbody = collider.attachedRigidbody;
			bool flag = attachedRigidbody != null && (applyNormalExplosionToHitObject || attachedRigidbody != hitRigid);
			if (flag)
			{
				for (int k = 0; k < num2; k++)
				{
					if (nearbyRigids[k] == attachedRigidbody && !applyNormalExplosionToHitObject)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				continue;
			}
			nearbyRigids[num2] = attachedRigidbody;
			if (KeepOldVelocity)
			{
				Vector3 velocity = attachedRigidbody.velocity * 0.9f;
				velocity.y *= 0.5f;
				attachedRigidbody.velocity = velocity;
			}
			attachedRigidbody.AddExplosionForce(power, position, radius, 2.15f);
			IExplodable component2 = attachedRigidbody.GetComponent<IExplodable>();
			if (component2 != null)
			{
				component2.OnExplode();
			}
			num2++;
			if (ball != null && attachedRigidbody.gameObject == ball.gameObject)
			{
				ball.TimedBlockShot(PlayerBlockDuration);
			}
		}
		if (screenShake && CameraManager.Instance != null)
		{
			CameraManager.Instance.Shake(0.5f, 20f, 2f);
		}
		if (rigid != null)
		{
			rigid.AddForce(Vector3.up * 6f + UnityEngine.Random.onUnitSphere * 0.7f);
			rigid.AddTorque(UnityEngine.Random.onUnitSphere * 300f, ForceMode.Impulse);
		}
		if (DestroyOnExplosion)
		{
			if (ps != null)
			{
				ps.transform.SetParent(null);
				ParticleSystem.MainModule main = ps.main;
				main.stopAction = ParticleSystemStopAction.Destroy;
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (failOnExplode && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	public void Reset()
	{
		if (burnedRender != null)
		{
			burnedRender.enabled = false;
		}
		if (normalRender != null)
		{
			normalRender.enabled = true;
		}
		didExplode = false;
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(base.transform.position, radius);
	}
}
