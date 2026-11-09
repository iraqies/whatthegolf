using System.Collections.Generic;
using UnityEngine;

public class OverworldTriggerCameraBlender : MonoBehaviour
{
	public OverworldCameraSettings CameraSettings;

	public List<SpriteRenderer> backgroundRenderers;

	public Color baseBackground;

	public Color endBackground;

	private bool ballIsInside;

	private Coroutine current;

	private float lastPct;

	private Collider2D collider;

	public bool dontBlend;

	private void Awake()
	{
		collider = GetComponent<Collider2D>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (dontBlend || other == null) return;
		if (other.GetComponentInParent<OverworldBall2D>() != null)
		{
			ballIsInside = true;
			BlendIn(0.4f);
		}
	}

	public void BlendIn(float time)
	{
		if (current != null) StopCoroutine(current);
		float startPct = lastPct;
		current = StartCoroutine(pTween.To(Mathf.Max(0.05f, time), t =>
		{
			lastPct = Mathf.Lerp(startPct, 1f, t);
			if (CameraSettings != null)
				CameraSettings.SetValue(lastPct);
			if (backgroundRenderers != null)
			{
				Color c = Color.Lerp(baseBackground, endBackground, lastPct);
				for (int i = 0; i < backgroundRenderers.Count; i++)
					if (backgroundRenderers[i] != null) backgroundRenderers[i].color = c;
			}
		}));
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (dontBlend || other == null) return;
		if (other.GetComponentInParent<OverworldBall2D>() != null)
		{
			ballIsInside = false;
			BlendOut(0.4f);
		}
	}

	public void BlendOut(float time)
	{
		if (current != null) StopCoroutine(current);
		float startPct = lastPct;
		current = StartCoroutine(pTween.To(Mathf.Max(0.05f, time), t =>
		{
			lastPct = Mathf.Lerp(startPct, 0f, t);
			if (CameraSettings != null)
				CameraSettings.SetValue(lastPct);
			if (backgroundRenderers != null)
			{
				Color c = Color.Lerp(baseBackground, endBackground, lastPct);
				for (int i = 0; i < backgroundRenderers.Count; i++)
					if (backgroundRenderers[i] != null) backgroundRenderers[i].color = c;
			}
		}));
	}

	public void BlendInWithoutSettings() => BlendIn(0.4f);
	public void BlendOutWithoutSettings() => BlendOut(0.4f);
}
