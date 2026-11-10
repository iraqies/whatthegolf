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
		Initialize();
		if (!SkipIntro)
		{
			yield return StartCoroutine(IntroRoutine());
		}
		yield return StartCoroutine(PlayRoutine());
		yield return StartCoroutine(OutroRoutine());
		Cleanup();
	}

	public void Initialize()
	{
		playerEnteredMouth = false;
		if (ObjectsToDisableOnStart != null)
		{
			for (int i = 0; i < ObjectsToDisableOnStart.Count; i++)
			{
				if (ObjectsToDisableOnStart[i] != null)
				{
					ObjectsToDisableOnStart[i].SetActive(false);
				}
			}
		}
		if (Boss != null)
		{
			Boss.gameObject.SetActive(true);
		}
		if (FrogKing != null)
		{
			FrogKing.Initialize();
		}
	}

	private IEnumerator IntroRoutine()
	{
		GameObject introCam = IntroCamerasMobile != null ? IntroCamerasMobile : IntroCamerasStandalone;
		if (introCam != null)
		{
			introCam.SetActive(true);
		}
		if (IntroBubbles != null)
		{
			IntroBubbles.Play();
		}
		if (introWaterSFX != null)
		{
			AudioManager.PlaySFX(introWaterSFX);
		}
		yield return new WaitForSeconds(1.5f);
		if (Tentacles != null)
		{
			for (int i = 0; i < Tentacles.Count; i++)
			{
				if (Tentacles[i] != null)
				{
					Tentacles[i].gameObject.SetActive(true);
				}
			}
		}
		if (tentacleEmergeSFX != null)
		{
			AudioManager.PlaySFX(tentacleEmergeSFX);
		}
		yield return new WaitForSeconds(1.5f);
		if (introCam != null)
		{
			introCam.SetActive(false);
		}
	}

	private IEnumerator PlayRoutine()
	{
		GameObject playerCam = PlayerCamMobile != null ? PlayerCamMobile : PlayerCamStandalone;
		if (playerCam != null)
		{
			playerCam.SetActive(true);
		}
		if (Player != null)
		{
			Player.gameObject.SetActive(true);
		}
		while (!playerEnteredMouth && (FrogKing == null || FrogKing.IsAlive))
		{
			yield return null;
		}
	}

	private void OnEnterMouth()
	{
		playerEnteredMouth = true;
	}

	private void OnSinkBefore()
	{
		if (islandSinkSFX != null)
		{
			AudioManager.PlaySFX(islandSinkSFX);
		}
		if (FrogKing != null)
		{
			FrogKing.PlayerIsAboutToReset();
		}
	}

	private void OnSinkAfterTransition()
	{
		if (FrogKing != null)
		{
			FrogKing.SinkResetAfter();
		}
	}

	private void OnSinkReset()
	{
		if (FrogKing != null)
		{
			FrogKing.SinkReset();
		}
	}

	private IEnumerator OutroRoutine()
	{
		OnSinkBefore();
		yield return new WaitForSeconds(1f);
		OnSinkAfterTransition();
	}

	public void Cleanup()
	{
		GameObject playerCam = PlayerCamMobile != null ? PlayerCamMobile : PlayerCamStandalone;
		if (playerCam != null)
		{
			playerCam.SetActive(false);
		}
	}
}
