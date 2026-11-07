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
	}

	private void OnDisable()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnZoneEnter(OverworldZoneAmbience zone)
	{
	}

	private void OnZoneExit(OverworldZoneAmbience zone)
	{
	}

	private void OnZoneChange()
	{
	}

	private void OverworldManager_OnEnableOverworld()
	{
	}
}
