using System;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class BreakableVase : MonoBehaviour
{
	public string Notes = "";

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

	public UnityEvent OnShattered;

	private Collision collisionWithOther;

	public Action<IHitscanTarget> OnHitscanHit { get; set; }

	public event Action OnBreak;

	private void Awake()
	{
		shatter = GetComponentInChildren<ObjectShatter>();
		if (shatter != null)
		{
			shatter.transform.SetParent(null);
		}
		if (DestroyGameobject == null)
		{
			DestroyGameobject = base.gameObject;
		}
	}

	public void ExternalBreak()
	{
		if (!hasShattered)
		{
			ShatterForce /= 5f;
			Shatter(base.transform.position);
		}
	}

	private void Shatter(Vector3 hit)
	{
		if (disableComponentsOnBreak != null)
		{
			for (int i = 0; i < disableComponentsOnBreak.Length; i++)
			{
				if (disableComponentsOnBreak[i] != null)
				{
					disableComponentsOnBreak[i].enabled = false;
				}
			}
		}
		if (shatter != null)
		{
			shatter.transform.position = base.transform.position;
			shatter.transform.rotation = base.transform.rotation;
			shatter.Shatter(hit, ShatterForce, 0.1f, 0.1f, true);
		}
		if (ShatterClips != null)
		{
			ShatterClips.PlayRandomClip(base.transform.position);
		}
		if (DestroyGameobject != null)
		{
			UnityEngine.Object.Destroy(DestroyGameobject);
		}
		this.OnBreak?.Invoke();
		if (FailLevelOnBreak && collisionWithOther != null && collisionWithOther.gameObject.tag != "GolfGoal" && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, failDelay, true, "");
		}
		if (OnShattered != null)
		{
			OnShattered.Invoke();
		}
		hasShattered = true;
	}

	private void OnCollisionEnter(Collision other)
	{
		collisionWithOther = other;
		if (other == null)
		{
			return;
		}
		int value = BlacklistLayers;
		if (value != (value | (1 << other.gameObject.layer)) && !hasShattered && other.impulse.sqrMagnitude > breakThreshold)
		{
			ShatterForce /= 5f;
			Shatter(other.GetContact(0).point);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("OutOfBounds") && !hasShattered)
		{
			Shatter(base.transform.position);
		}
	}
}
