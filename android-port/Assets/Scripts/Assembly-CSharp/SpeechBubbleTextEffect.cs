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

	[SerializeField] private AudioClip charSound;
	[SerializeField] private CharSoundMode charSoundMode;
	[SerializeField] private float charTime = 0.03f;
	[SerializeField] private float spaceTime = 0.03f;
	[SerializeField] private float newLineTime = 0.03f;
	[SerializeField] private float punctuationTime = 0.08f;

	private StringBuilder sb = new StringBuilder();
	private readonly HashSet<char> vowels = new HashSet<char> { 'e', 'y', 'u', 'o', 'a', 'i' };

	public IEnumerator PlaySequence(string text, Action<string> changeTextCallback)
	{
		if (string.IsNullOrEmpty(text))
			yield break;
		if (sb == null)
			sb = new StringBuilder();

		for (int i = 0; i < text.Length; i++)
		{
			PlayCharSound(text.Substring(i));
			float dur = CharDuration(text[i]);
			if (dur > 0f)
			{
				int idx = i;
				yield return pTween.To(dur, 0f, 1f, t =>
				{
					sb.Length = 0;
					sb.Append("<color=#000000FF>");
					sb.Append(text, 0, idx);
					sb.Append("</color>");
					sb.Append("<color=#000000");
					sb.Append(RatioToHex(t));
					sb.Append(">");
					sb.Append(text[idx]);
					sb.Append("</color>");
					sb.Append("<color=#00000000>");
					sb.Append(text, idx + 1, text.Length - idx - 1);
					sb.Append("</color>");
					changeTextCallback?.Invoke(sb.ToString());
				});
			}
		}
		changeTextCallback?.Invoke(text);
	}

	private void PlayCharSound(string remainingText)
	{
		if (charSound == null || string.IsNullOrEmpty(remainingText))
			return;
		char c = remainingText[0];
		if (!char.IsLetterOrDigit(c))
			return;
		if (charSoundMode == CharSoundMode.Syllables && remainingText.Length > 1 && IsVowel(c) && IsVowel(remainingText[1]))
			return;
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null)
		{
			AudioManager.Instance.sfx.PlaySimple(charSound, 0.25f, UnityEngine.Random.Range(0.95f, 1.05f), Vector3.zero);
		}
	}

	private bool IsVowel(char c)
	{
		return vowels != null && vowels.Contains(char.ToLowerInvariant(c));
	}

	private float CharDuration(char c)
	{
		if (c == '\n') return newLineTime;
		if (c == ' ') return spaceTime;
		if (char.IsPunctuation(c)) return punctuationTime;
		return charTime > 0f ? charTime : 0.03f;
	}

	private string RatioToHex(float t)
	{
		return Mathf.Clamp(Mathf.RoundToInt(Mathf.Clamp01(t) * 255f), 0, 255).ToString("X2");
	}
}
