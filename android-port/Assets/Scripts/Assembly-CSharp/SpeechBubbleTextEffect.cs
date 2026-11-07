using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SpeechBubbleTextEffect : ScriptableObject
{
	public enum CharSoundMode
	{
		Characters = 0,
		Syllables = 1
	}

	[SerializeField]
	private AudioClip charSound;

	[SerializeField]
	private CharSoundMode charSoundMode;

	[SerializeField]
	private float charTime;

	[SerializeField]
	private float spaceTime;

	[SerializeField]
	private float newLineTime;

	[SerializeField]
	private float punctuationTime;

	private StringBuilder sb;

	private readonly HashSet<char> vowels;

	public IEnumerator PlaySequence(string text, Action<string> changeTextCallback)
	{
		return null;
	}

	private void PlayCharSound(string remainingText)
	{
	}

	private bool IsVowel(char c)
	{
		return false;
	}

	private float CharDuration(char c)
	{
		return 0f;
	}

	private string RatioToHex(float t)
	{
		return null;
	}
}
