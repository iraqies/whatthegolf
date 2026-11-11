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
		StopAllCoroutines();
	}

	private void OnEnable()
	{
		Start();
	}

	private void Start()
	{
		if (m_snowballParticle != null)
		{
			m_particleSystemsToUpdate = new List<ParticleSystem>(m_snowballParticle.GetComponentsInChildren<ParticleSystem>());
			m_particleSystemsToUpdate.Add(m_snowballParticle.GetComponent<ParticleSystem>());
		}
		if (m_direction == Direction.RIGHT && animator != null)
		{
			animator.SetBool("ThrowsRight", true);
		}
		StartCoroutine(KidWaitingSequence());
	}

	public override void TriggerEvent()
	{
		if (m_currentSnowballSequence != null)
		{
			if (m_snowballParticle != null)
			{
				m_snowballParticle.Stop();
			}
			StopCoroutine(m_currentSnowballSequence);
		}
		RandomizeSeeds();
		m_currentSnowballSequence = StartCoroutine(SnowballSequence());
	}

	private void RandomizeSeeds()
	{
		uint randomSeed = (uint)Random.Range(0, 100);
		if (m_particleSystemsToUpdate == null)
		{
			return;
		}
		for (int i = 0; i < m_particleSystemsToUpdate.Count; i++)
		{
			if (m_particleSystemsToUpdate[i] != null)
			{
				m_particleSystemsToUpdate[i].randomSeed = randomSeed;
			}
		}
	}

	private IEnumerator KidWaitingSequence()
	{
		float seconds = Random.Range(0f, MaxTimeBeforeSnowballPickup);
		yield return new WaitForSeconds(seconds);
		if (animator != null)
		{
			animator.SetBool("WantsSnowball", true);
		}
		yield return new WaitForSeconds(PickupDuration);
		if (animator != null)
		{
			animator.SetBool("WantsSnowball", false);
		}
		hasSnowball = true;
	}

	private IEnumerator SnowballSequence()
	{
		if (!hasSnowball)
		{
			yield break;
		}
		if (m_direction == Direction.LEFT && m_snowballThrower != null)
		{
			m_snowballThrower.SetTrigger("ShowL");
		}
		if (m_direction == Direction.RIGHT && m_snowballThrower != null)
		{
			m_snowballThrower.SetTrigger("ShowR");
		}
		if (sfxLaugh != null)
		{
			sfxLaugh.Play(base.transform.position);
		}
		if (animator != null)
		{
			animator.SetTrigger("ThrowSnowball");
		}
		yield return new WaitForSeconds(0.25f);
		if (sfxOnShoot != null)
		{
			sfxOnShoot.Play(null, base.transform.position);
		}
		if (m_snowballParticle != null)
		{
			m_snowballParticle.Play();
		}
		hasSnowball = false;
		StartCoroutine(KidWaitingSequence());
		yield return null;
	}
}
