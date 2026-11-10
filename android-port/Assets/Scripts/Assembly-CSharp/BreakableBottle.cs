using System;
using System.Runtime.CompilerServices;
using Audio;
using Core;
using UnityEngine;

public class BreakableBottle : MonoBehaviour, IHitscanTarget
{
	[CompilerGenerated]
	private Action m_OnBreak;

	public float ShatterForce = 10f;

	public float breakThreshold = 2f;

	public RandomAudioClips ShatterClips;

	public LayerMask BlacklistLayers;

	public GameObject DestroyGameobject;

	public bool FailLevelOnBreak;

	public float failDelay = 1f;

	public MonoBehaviour[] disableComponentsOnBreak;

	private ObjectShatter shatter;

	private bool hasShattered;

	public Action<IHitscanTarget> OnHitscanHit { get; set; }

	public event Action OnBreak
	{
		[CompilerGenerated]
		add => m_OnBreak = (Action)Delegate.Combine(m_OnBreak, value);
		[CompilerGenerated]
		remove => m_OnBreak = (Action)Delegate.Remove(m_OnBreak, value);
	}

	private void Awake()
	{
		shatter = GetComponentInChildren<ObjectShatter>();
		if (shatter != null)
			shatter.transform.SetParent(null);
		if (DestroyGameobject == null)
			DestroyGameobject = gameObject;
	}

	public void ExternalBreak()
	{
		if (hasShattered) return;
		ShatterForce /= 5f;
		Shatter(transform.position);
	}

	public void OnHit(Vector3 hit)
	{
		OnHitscanHit?.Invoke(this);
		Shatter(hit);
	}

	private void Shatter(Vector3 hit)
	{
		if (disableComponentsOnBreak != null)
		{
			for (int i = 0; i < disableComponentsOnBreak.Length; i++)
			{
				if (disableComponentsOnBreak[i] != null)
					disableComponentsOnBreak[i].enabled = false;
			}
		}
		if (shatter != null)
		{
			shatter.transform.position = transform.position;
			shatter.transform.rotation = transform.rotation;
			shatter.Shatter(hit, ShatterForce, 0.1f, 0.1f, ForceMode.Impulse);
		}
		if (ShatterClips != null)
			ShatterClips.PlayRandomClip(transform.position);
		if (DestroyGameobject != null)
			Destroy(DestroyGameobject);
		m_OnBreak?.Invoke();
		if (FailLevelOnBreak && Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, failDelay, true, "OUT OF BOUNDS");
		}
		hasShattered = true;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null) return;
		int mask = BlacklistLayers.value;
		if ((mask | (1 << other.gameObject.layer)) == mask)
			return;
		if (hasShattered)
			return;
		if (other.impulse.sqrMagnitude > breakThreshold)
		{
			ShatterForce /= 5f;
			Vector3 pt = other.contactCount > 0 ? other.GetContact(0).point : transform.position;
			Shatter(pt);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (other.CompareTag("KillZone") && !hasShattered)
		{
			Shatter(transform.position);
		}
	}
}
