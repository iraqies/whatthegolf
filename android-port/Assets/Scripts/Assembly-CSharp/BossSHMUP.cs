using System.Collections;
using System.Collections.Generic;
using Audio;
using Cinemachine;
using UnityEngine;

public class BossSHMUP : MonoBehaviour
{
	public Rigidbody Boss;

	public FinalBoss FinalBoss;

	public ParticleSystem IntroBubbles;

	public List<TentacleController> Tentacles;

	public Rigidbody PreviousBossCar;

	public SHMUPController Player;

	public SHMUPFrogKing FrogKing;

	public GameObject IntroCamerasStandalone;

	public GameObject IntroCamerasMobile;

	public GameObject PlayerCamStandalone;

	public GameObject PlayerCamMobile;

	public List<GameObject> ObjectsToDisableOnStart;

	public AudioClipSettings introWaterSFX;

	public AudioClipSettings tentacleEmergeSFX;

	public AudioClipSettings islandSinkSFX;

	public uint emptyWwiseState;

	public uint bossStateMusic;

	public bool SkipIntro;

	public CinemachineStateDrivenCamera testPlayerCam;

	private bool playerEnteredMouth;

	public IEnumerator StageRoutine()
	{
		return null;
	}

	public void Initialize()
	{
	}

	private IEnumerator IntroRoutine()
	{
		return null;
	}

	private IEnumerator PlayRoutine()
	{
		return null;
	}

	private void OnEnterMouth()
	{
	}

	private void OnSinkBefore()
	{
	}

	private void OnSinkAfterTransition()
	{
	}

	private void OnSinkReset()
	{
	}

	private IEnumerator OutroRoutine()
	{
		return null;
	}

	public void Cleanup()
	{
	}
}
