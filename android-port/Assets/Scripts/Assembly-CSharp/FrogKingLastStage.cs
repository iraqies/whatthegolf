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

	public float GoDownSpeed = 1f;

	public GolfBallController Player;

	public MeshRenderer GroundRenderer;

	public float SinkDepth = 50f;

	public ParticleSystem WinParticles;

	public AudioClipSettings endVortexSFX;

	public AudioSource birdsAudioSource;

	public AudioClipSettings confettiSFX;

	public uint triumpMusicState;

	public OverworldMusicData triumphOverworldMusic;

	private Coroutine outroRoutine;

	private void Start()
	{
		Physics.gravity = Gravity;
	}

	public IEnumerator PlayRoutine()
	{
		yield return null;
	}

	public void HitPlug()
	{
		if (outroRoutine == null)
		{
			outroRoutine = StartCoroutine(UnplugRoutine());
		}
	}

	private IEnumerator UnplugRoutine()
	{
		if (Player != null)
			Player.enabled = false;

		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels)
		{
			if (CameraStandalone != null)
				CameraStandalone.SetActive(false);
			if (CameraMobile != null)
				CameraMobile.SetActive(true);
		}
		else
		{
			if (CameraStandalone != null)
				CameraStandalone.SetActive(true);
			if (CameraMobile != null)
				CameraMobile.SetActive(false);
		}

		yield return new WaitForSeconds(1f);

		if (PlugAnimation != null)
			PlugAnimation.SetTrigger("Unplug");

		OverworldMusic musicZone = FindObjectOfType<OverworldMusic>();
		if (musicZone != null)
			musicZone.current = triumphOverworldMusic;

		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetState(triumpMusicState, false, null, false);

		while (PlugAnimation != null)
		{
			AnimatorStateInfo stateInfo = PlugAnimation.GetCurrentAnimatorStateInfo(0);
			if (stateInfo.IsName("Exit"))
			{
				PlugAnimation.enabled = false;
				yield return new WaitForSeconds(1f);
				break;
			}
			yield return null;
		}

		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRumble)
		{
			StartCoroutine(pTween.To(5.7f, f =>
			{
				float val = Mathf.Lerp(0.2f, 1f, f);
				if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null)
					AudioManager.Instance.rumbleManager.PlayVibrationValue(val, 85f, 0f, 0f, 0, null);
			}).Then(pTween.To(1.2f, f =>
			{
				float val = Mathf.Lerp(1f, 0f, f);
				if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null)
					AudioManager.Instance.rumbleManager.PlayVibrationValue(val, 85f, 0f, 0f, 0, null);
			})).Then(() =>
			{
				if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null)
					AudioManager.Instance.rumbleManager.StopVibration(0);
			}));
		}

		if (VortexParticles != null)
			VortexParticles.Play();
		if (endVortexSFX != null)
			endVortexSFX.Play(null, Vector3.zero, 0f);

		yield return new WaitForSeconds(2f);

		if (ObjectsToMoveDown != null)
		{
			foreach (Transform trans in ObjectsToMoveDown)
			{
				if (trans != null)
					StartCoroutine(MoveDown(trans));
			}
		}

		yield return new WaitForSeconds(5f);

		if (birdsAudioSource != null)
		{
			birdsAudioSource.Play();
			StartCoroutine(pTween.To(2f, s =>
			{
				if (birdsAudioSource != null)
					birdsAudioSource.volume = s;
			}));
		}

		yield return StartCoroutine(pTween.To(3f, t =>
		{
			if (GroundRenderer != null && GroundRenderer.material != null)
			{
				GroundRenderer.material.SetFloat("_StepThreshold", Mathf.Lerp(0.7f, 0.4f, TweenFunctions.EaseOut(t)));
			}
		}));

		if (WinParticles != null)
			WinParticles.Play();
		if (confettiSFX != null)
			confettiSFX.Play(null, Vector3.zero, 0f);

		if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && AudioManager.Instance.rumbleManager.BumpHard != null)
		{
			AudioManager.Instance.rumbleManager.BumpHard.Play(0, 1f);
		}

		if (Level.Instance != null)
			Level.Instance.Complete(null, null, null, 0);
	}

	private IEnumerator MoveDown(Transform trans)
	{
		if (trans == null)
			yield break;
		Vector3 startPos = trans.position;
		Vector3 endPos = startPos + Vector3.down * SinkDepth;
		yield return StartCoroutine(pTween.To(5f, t =>
		{
			if (trans != null)
				trans.position = Vector3.Lerp(startPos, endPos, Mathf.Clamp01(t));
		}));
	}
}
