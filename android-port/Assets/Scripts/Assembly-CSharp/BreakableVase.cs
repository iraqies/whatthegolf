using System;
using System.Runtime.CompilerServices;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class BreakableVase : MonoBehaviour
{
	public string Notes;

	[CompilerGenerated]
	private Action m_OnBreak;

	public float ShatterForce;

	public float breakThreshold;

	public RandomAudioClips ShatterClips;

	public LayerMask BlacklistLayers;

	public GameObject DestroyGameobject;

	public bool FailLevelOnBreak;

	public float failDelay;

	public MonoBehaviour[] disableComponentsOnBreak;

	private ObjectShatter shatter;

	private bool hasShattered;

	public UnityEvent OnShattered;

	private Collision collisionWithOther;

	public Action<IHitscanTarget> OnHitscanHit { get; set; }

	public event Action OnBreak
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

	public void ExternalBreak()
	{
	}

	private void Shatter(Vector3 hit)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
