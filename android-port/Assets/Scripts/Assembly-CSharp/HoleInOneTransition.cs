using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HoleInOneTransition : MonoBehaviour
{
	public AudioClip sfxWin;

	public AudioClip sfxLost;

	public float volume = 0.2f;

	public Color winColor = Color.green;

	public Color loseColor = Color.red;

	public float inScale = 1f;

	public float outScale = 0.01f;

	public SpriteRenderer endCoverSprite;

	private List<SpriteRenderer> sprites = new List<SpriteRenderer>();

	private Vector3 basePosition;

	public void InstantIn()
	{
		transform.localScale = Vector3.zero;
		transform.position = new Vector3(0f, 0f, basePosition.z);
		transform.localScale = Vector3.one * inScale;
		if (sprites != null)
		{
			foreach (SpriteRenderer sr in sprites)
			{
				if (sr != null)
				{
					sr.color = winColor;
					sr.enabled = true;
				}
			}
		}
	}

	private void Awake()
	{
		sprites = GetComponentsInChildren<SpriteRenderer>(true).ToList();
		basePosition = transform.position;
		if (sprites != null)
		{
			foreach (SpriteRenderer sr in sprites)
			{
				if (sr != null)
					sr.enabled = false;
			}
		}
	}

	public void StarTransition(Vector3 pos, bool isWon, Action onClear)
	{
		transform.localScale = Vector3.zero;
		transform.position = new Vector3(pos.x, pos.y, basePosition.z);
		transform.localScale = Vector3.one * outScale;
		if (sprites != null)
		{
			Color c = isWon ? winColor : loseColor;
			foreach (SpriteRenderer sr in sprites)
			{
				if (sr != null)
				{
					sr.color = c;
					sr.enabled = true;
				}
			}
		}

		float startMag = transform.localScale.magnitude;
		StartCoroutine(pTween.To(0.4f, startMag, inScale, t =>
		{
			transform.localScale = Vector3.one * t;
		}).Then(() =>
		{
			onClear?.Invoke();
		}));

		if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioClip clip = isWon ? sfxWin : sfxLost;
			if (clip != null)
			{
				AudioManager.Instance.shortEffects.Play(clip, s =>
				{
					if (s != null)
						s.volume = volume;
				}, 0f, false);
			}
		}
	}

	public void EndTransition(Vector3 pos, Action onCompleted)
	{
		if (endCoverSprite != null)
			endCoverSprite.enabled = false;

		transform.position = new Vector3(pos.x, pos.y, basePosition.z);
		StartCoroutine(pTween.To(0.8f, s =>
		{
			float val = Mathf.Lerp(inScale, outScale, TweenFunctions.EaseIn(s));
			transform.localScale = Vector3.one * val;
		}).Then(() =>
		{
			onCompleted?.Invoke();
		}).Then(() =>
		{
			if (sprites != null)
			{
				foreach (SpriteRenderer sr in sprites)
				{
					if (sr != null)
						sr.enabled = false;
				}
			}
			transform.localScale = Vector3.zero;
		}));
	}
}
