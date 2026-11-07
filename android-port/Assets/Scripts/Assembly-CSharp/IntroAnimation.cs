using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class IntroAnimation : MonoBehaviour
{
	public IntroTunnelInOverworld tunnel;

	public List<SpriteRenderer> backgrounds;

	public List<SpriteRenderer> darkOverlays;

	public Color bgnormalColor;

	public Color bgdarkColor;

	public SaveSpot save;

	public SpriteRenderer hallwayOverlay;

	public SpriteRenderer button;

	public SpriteRenderer buttonBase;

	public Color buttonOffColor;

	public Color buttonBaseOffColor;

	public SpriteRenderer darkScreen;

	public ShowSpeechbubbleOnHit speechbubble;

	public Animator face;

	public OverworldButton2D door;

	public ParticleSystem buttonParticles;

	public ParticleSystem topRightParticles;

	public ParticleSystem topLeftParticles;

	public Color DarknessDark;

	public Color DarknessLight;

	public SpriteRenderer DarknessRenderer;

	public IntroComputer introComputer;

	public AudioClipSettings TurnOnLightClip;

	public AudioClipSettings StaticNoiseClip;

	public float ComputerOnVolume;

	public AudioSource ComputerOnSource;

	private void Awake()
	{
	}

	private void Tunnel_OnAtLogo()
	{
	}

	private IEnumerator IntroRoutine()
	{
		return null;
	}
}
