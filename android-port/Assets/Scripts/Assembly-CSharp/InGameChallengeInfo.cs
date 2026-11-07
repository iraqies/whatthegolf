using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using TMPro;
using UnityEngine;

public class InGameChallengeInfo : MonoBehaviour
{
	public TextMeshProUGUI ChallengeText;

	public RectTransform Container;

	public float Height;

	public float IconExtraHeight;

	public float HoldDuration;

	public float MobileWidth;

	public float StandaloneWidth;

	public GameObject IconImagePrefab;

	public int MaxIcons;

	public float SpacingBetweenIcons;

	public float IconHeight;

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
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnLevelWillUnload()
	{
	}

	public void Show(string text)
	{
	}

	private IEnumerator Routine(string text)
	{
		return null;
	}

	private IEnumerator WaitForPlayerShot(Action OnReady)
	{
		return null;
	}

	public void Show(string text, Sprite[] icons)
	{
	}

	private IEnumerator Routine(string text, Sprite[] icons)
	{
		return null;
	}

	private void LayoutIcons(Sprite[] icons)
	{
	}

	private void ResetIconsAndText()
	{
	}
}
