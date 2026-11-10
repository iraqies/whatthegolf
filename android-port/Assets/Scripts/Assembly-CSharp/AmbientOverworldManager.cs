using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Audio;

public class AmbientOverworldManager : MonoBehaviour
{
	public OverworldManager2d overworldManager;

	public OverworldBall2D ball;

	public List<AmbientAudio> defaultAmbientOutsideZones;

	public AudioMixerSnapshot defaultSnapshot;

	private OverworldZoneAmbience currentZone;

	private AmbientAudioPlayer ambient;

	private bool applicationIsQuitting;

	private void Start()
	{
		if (overworldManager == null)
		{
			overworldManager = OverworldManager2d.Instance;
		}
		if (AudioManager.Instance != null)
		{
			ambient = AudioManager.Instance.AmbientPlayer;
		}
		if (defaultSnapshot != null)
		{
			defaultSnapshot.TransitionTo(0.5f);
		}
		OnZoneChange();
	}

	private void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
		applicationIsQuitting = true;
	}

	private void OnZoneEnter(OverworldZoneAmbience zone)
	{
		currentZone = zone;
		OnZoneChange();
	}

	private void OnZoneExit(OverworldZoneAmbience zone)
	{
		if (currentZone == zone)
		{
			currentZone = null;
			OnZoneChange();
		}
	}

	private void OnZoneChange()
	{
		if (applicationIsQuitting)
		{
			return;
		}
		if (currentZone == null && defaultSnapshot != null)
		{
			defaultSnapshot.TransitionTo(0.5f);
		}
	}

	private void OverworldManager_OnEnableOverworld()
	{
		OnZoneChange();
	}
}
