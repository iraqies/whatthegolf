using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class DefaultTransitionEffect : BaseTransitionEffect
{
	[SerializeField] private Transform circleTransform;
	[SerializeField] private MeshRenderer circleRenderer;
	[SerializeField] private Transform endCircleTransform;
	[SerializeField] private MeshRenderer endCircleRenderer;
	[SerializeField] private List<AudioClip> transitionClips;
	private Material bgMaterial;
	private Color defaultBgColor = new Color(0.12f, 0.72f, 0.65f, 1f);

	public override void Init()
	{
		if (circleTransform != null)
			circleTransform.localScale = Vector3.zero;
		if (endCircleTransform != null)
			endCircleTransform.localScale = Vector3.zero;
		if (circleRenderer != null)
		{
			circleRenderer.enabled = false;
			if (circleRenderer.sharedMaterial != null)
			{
				bgMaterial = new Material(circleRenderer.sharedMaterial);
				circleRenderer.sharedMaterial = bgMaterial;
				defaultBgColor = bgMaterial.color;
			}
		}
		if (endCircleRenderer != null)
		{
			endCircleRenderer.enabled = false;
			if (bgMaterial != null)
				endCircleRenderer.sharedMaterial = bgMaterial;
		}
	}

	public override void PreBegin(Color? color)
	{
		if (bgMaterial == null) Init();
		if (bgMaterial != null)
			bgMaterial.color = color ?? defaultBgColor;
		if (circleTransform != null)
			circleTransform.localScale = Vector3.zero;
		if (circleRenderer != null)
			circleRenderer.enabled = true;
		if (endCircleRenderer != null)
			endCircleRenderer.enabled = false;
	}

	public override IEnumerator Begin()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.uiEffects != null && transitionClips != null && transitionClips.Count > 0)
		{
			AudioManager.Instance.uiEffects.Play(transitionClips, null, false, 0.1f, false);
		}
		yield return StartCoroutine(pTween.ToRealTime(0.4f, t =>
		{
			if (circleTransform != null)
				circleTransform.localScale = Vector3.one * (t * t * 0.006939f);
		}));
	}

	public override void CleanUp()
	{
		if (circleRenderer != null)
			circleRenderer.enabled = false;
		if (endCircleRenderer != null)
			endCircleRenderer.enabled = false;
		if (circleTransform != null)
			circleTransform.localScale = Vector3.zero;
		if (endCircleTransform != null)
			endCircleTransform.localScale = Vector3.zero;
	}

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		if (endCircleTransform != null)
			endCircleTransform.localScale = Vector3.one * 0.002055f;
		if (endCircleRenderer != null)
			endCircleRenderer.enabled = true;
		if (circleRenderer != null)
			circleRenderer.enabled = false;
		if (AudioManager.Instance != null && AudioManager.Instance.uiEffects != null && transitionClips != null && transitionClips.Count > 0)
		{
			AudioManager.Instance.uiEffects.Play(transitionClips, null, false, 0.1f, true);
		}
		float dur = overrideTransitionDuration > 0.01f ? overrideTransitionDuration : 0.4f;
		yield return StartCoroutine(pTween.ToRealTime(dur, t =>
		{
			if (endCircleTransform != null)
				endCircleTransform.localScale = Vector3.one * Mathf.Lerp(0.002055f, 0.5123f, t);
		}));
		CleanUp();
	}

	public override void InstantTransitionCover(Color? color)
	{
		if (bgMaterial == null) Init();
		if (bgMaterial != null)
			bgMaterial.color = color ?? defaultBgColor;
		if (circleTransform != null)
			circleTransform.localScale = Vector3.one * 0.006939f;
		if (circleRenderer != null)
			circleRenderer.enabled = true;
		if (endCircleRenderer != null)
			endCircleRenderer.enabled = false;
	}
}
