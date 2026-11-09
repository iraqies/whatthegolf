using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using TMPro;
using UnityEngine;

public class InGameChallengeInfo : MonoBehaviour
{
	public TextMeshProUGUI ChallengeText;

	public RectTransform Container;

	public float Height = 120f;

	public float IconExtraHeight = 80f;

	public float HoldDuration = 2.5f;

	public float MobileWidth = 600f;

	public float StandaloneWidth = 600f;

	public GameObject IconImagePrefab;

	public int MaxIcons = 5;

	public float SpacingBetweenIcons = 60f;

	public float IconHeight = 50f;

	public float SoloTextY;

	public float IconTextY;

	public float IconY;

	public ClipSettingsCollection sfxOnAppear;

	public ClipSettingsCollection sfxOnDissapear;

	private List<SVGImage> iconImagePool;

	private float WaitTime;

	public bool ShowForMinSeconds;

	public void SetWaitSeconds(float seconds)
	{
		WaitTime = seconds;
	}

	private void Awake()
	{
		if (Container != null)
			Container.gameObject.SetActive(false);
	}

	private void Start()
	{
		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			LevelManager.Instance.OnLevelWillUnload -= OnLevelWillUnload;
			LevelManager.Instance.OnLevelWillUnload += OnLevelWillUnload;
		}
	}

	private void OnLevelWillUnload()
	{
		StopAllCoroutines();
		if (Container != null)
			Container.gameObject.SetActive(false);
	}

	public void Show(string text)
	{
		gameObject.SetActive(true);
		StopAllCoroutines();
		StartCoroutine(Routine(text));
	}

	private IEnumerator Routine(string text)
	{
		if (ChallengeText != null)
			ChallengeText.text = text ?? string.Empty;
		if (Container != null)
		{
			Container.gameObject.SetActive(true);
			Container.localScale = Vector3.one;
		}
		if (sfxOnAppear != null && AudioManager.Instance != null)
			sfxOnAppear.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);

		yield return new WaitForSecondsRealtime(HoldDuration > 0.2f ? HoldDuration : 2.5f);

		if (sfxOnDissapear != null && AudioManager.Instance != null)
			sfxOnDissapear.Play(AudioManager.Instance.uiEffects, Vector3.zero, 0f);
		if (Container != null)
			Container.gameObject.SetActive(false);
	}

	private IEnumerator WaitForPlayerShot(Action OnReady)
	{
		yield return new WaitForSecondsRealtime(HoldDuration > 0.2f ? HoldDuration : 2f);
		OnReady?.Invoke();
	}

	public void Show(string text, Sprite[] icons)
	{
		gameObject.SetActive(true);
		StopAllCoroutines();
		StartCoroutine(Routine(text, icons));
	}

	private IEnumerator Routine(string text, Sprite[] icons)
	{
		yield return StartCoroutine(Routine(text));
	}

	private void LayoutIcons(Sprite[] icons)
	{
	}

	private void ResetIconsAndText()
	{
	}
}
