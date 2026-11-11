using System;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class MarioBreakableBlock : MonoBehaviour
{
	public int ParticlesToEmitOnHit = 1;

	public int ParticlesToEmitOnBreak = 40;

	public int Health = 1;

	public bool Hidden;

	public ParticleSystem OnHitParticles;

	public ParticleSystem OnBreakParticles;

	public MarioLevelController Controller;

	public bool playClipOnHitForLastHealth;

	public RandomAudioClips ClipOnHit;

	public RandomAudioClips ClipOnBreak;

	public List<RumbleEventAsset> RumbleOnBreak;

	public Action<MarioBreakableBlock> OnBlockHit;

	public Action<MarioBreakableBlock> OnBlockBreak;

	private int currentHealth;

	private Renderer[] renderer;

	public GameObject DeadCubeObject;

	private void Awake()
	{
		if (Controller != null)
		{
			Controller.OnLevelReset -= OnLevelReset;
			Controller.OnLevelReset += OnLevelReset;
		}
		currentHealth = Health;
		renderer = GetComponentsInChildren<Renderer>(true);
		if (Hidden && renderer != null)
		{
			for (int i = 0; i < renderer.Length; i++)
			{
				if (renderer[i] != null)
					renderer[i].enabled = false;
			}
		}
	}

	private void OnLevelReset()
	{
		gameObject.SetActive(true);
		currentHealth = Health;
		if (renderer != null)
		{
			for (int i = 0; i < renderer.Length; i++)
			{
				if (renderer[i] != null)
					renderer[i].enabled = !Hidden;
			}
		}
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c == null || c.collider == null) return;
		if (c.collider.bounds.max.y < transform.position.y && c.collider.tag == "Player")
		{
			if (Hidden && renderer != null)
			{
				for (int i = 0; i < renderer.Length; i++)
				{
					if (renderer[i] != null)
						renderer[i].enabled = true;
				}
			}
			currentHealth--;
			OnHit();
			if (currentHealth <= 0)
			{
				OnBreak();
			}
		}
	}

	private void OnHit()
	{
		if (ClipOnHit != null && (playClipOnHitForLastHealth || currentHealth >= 1))
		{
			ClipOnHit.PlayRandomClip(transform.position);
		}
		if (OnHitParticles != null)
		{
			OnHitParticles.transform.position = transform.position;
			OnHitParticles.Emit(ParticlesToEmitOnHit);
		}
		OnBlockHit?.Invoke(this);
	}

	private void OnBreak()
	{
		if (ClipOnBreak != null)
		{
			ClipOnBreak.PlayRandomClip(transform.position);
		}
		if (RumbleOnBreak != null)
		{
			RumbleOnBreak.PlayOnAllControllers(1f);
		}
		if (OnBreakParticles != null)
		{
			OnBreakParticles.transform.position = transform.position;
			for (int i = 0; i < ParticlesToEmitOnBreak; i++)
			{
				var ep = default(ParticleSystem.EmitParams);
				ep.position = transform.position;
				ep.applyShapeToPosition = true;
				OnBreakParticles.Emit(ep, 1);
			}
		}
		OnBlockBreak?.Invoke(this);
		if (DeadCubeObject != null)
		{
			DeadCubeObject.SetActive(true);
			DeadCubeObject.transform.parent = null;
		}
		gameObject.SetActive(false);
	}
}
