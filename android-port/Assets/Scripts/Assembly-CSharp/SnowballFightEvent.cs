using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SnowballFightEvent : OverworldEvent
{
	public enum Direction
	{
		LEFT = 0,
		RIGHT = 1
	}

	[SerializeField]
	private ParticleSystem m_snowballParticle;

	[SerializeField]
	private Animator m_snowballThrower;

	[SerializeField]
	private Direction m_direction;

	[SerializeField]
	private float PickupDuration;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AudioEventAsset sfxLaugh;

	[SerializeField]
	private ClipSettingsCollection sfxOnShoot;

	private bool hasSnowball;

	[SerializeField]
	private float MaxTimeBeforeSnowballPickup;

	private Coroutine m_currentSnowballSequence;

	private List<ParticleSystem> m_particleSystemsToUpdate;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public override void TriggerEvent()
	{
	}

	private void RandomizeSeeds()
	{
	}

	private IEnumerator KidWaitingSequence()
	{
		return null;
	}

	private IEnumerator SnowballSequence()
	{
		return null;
	}
}
