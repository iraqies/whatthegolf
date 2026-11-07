using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class FrogKingLastStage : MonoBehaviour
{
	public GameObject CameraStandalone;

	public GameObject CameraMobile;

	public Vector3 Gravity;

	public Animator PlugAnimation;

	public ParticleSystem VortexParticles;

	public List<Transform> ObjectsToMoveDown;

	public GameObject GoopSea;

	public float GoDownSpeed;

	public GolfBallController Player;

	public MeshRenderer GroundRenderer;

	public float SinkDepth;

	public ParticleSystem WinParticles;

	public AudioClipSettings endVortexSFX;

	public AudioSource birdsAudioSource;

	public AudioClipSettings confettiSFX;

	public uint triumpMusicState;

	public OverworldMusicData triumphOverworldMusic;

	private Coroutine outroRoutine;

	private void Start()
	{
	}

	public IEnumerator PlayRoutine()
	{
		return null;
	}

	public void HitPlug()
	{
	}

	private IEnumerator UnplugRoutine()
	{
		return null;
	}

	private IEnumerator MoveDown(Transform trans)
	{
		return null;
	}
}
