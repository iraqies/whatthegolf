using System;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class MarioBreakableBlock : MonoBehaviour
{
	public int ParticlesToEmitOnHit;

	public int ParticlesToEmitOnBreak;

	public int Health;

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
	}

	private void OnLevelReset()
	{
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	private void OnHit()
	{
	}

	private void OnBreak()
	{
	}
}
