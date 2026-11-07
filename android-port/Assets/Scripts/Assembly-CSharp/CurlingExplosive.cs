using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class CurlingExplosive : MonoBehaviour, IAudioEvent
{
	[CompilerGenerated]
	private Action<Collider, CurlingExplosive> m_OnExplode;

	public UnityEvent OnExplodeEvent;

	public PlayClipOnAudioEvent ExplosionSFX;

	public bool failOnExplode;

	public float startCooldown;

	public bool canExplode;

	public ParticleSystem ps;

	public float impactThreshold;

	public float radius;

	public float power;

	public Renderer normalRender;

	public Renderer burnedRender;

	public bool screenShake;

	public float PlayerBlockDuration;

	public bool DestroyOnExplosion;

	public bool KeepOldVelocity;

	public float hitObjectExplosionForce;

	public Vector3 hitObjectExplosionForceModsMinRange;

	public Vector3 hitObjectExplosionForceModsMaxRange;

	public bool applyNormalExplosionToHitObject;

	public LayerMask ignoreLayers;

	public bool ExplodeOnOutOfBounds;

	public bool AddRandomAngularVelocity;

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

	public event Action<Collider, CurlingExplosive> OnExplode
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

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Update()
	{
	}

	public void SetExplosionTimer(float delay)
	{
	}

	public void Explode(Collider col = null)
	{
	}

	private void Explode(Vector3 normal, Collider col = null)
	{
	}

	public void Reset()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
