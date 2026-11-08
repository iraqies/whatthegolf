using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTransitionEffect : BaseTransitionEffect
{
	[SerializeField] private Transform circleTransform;
	[SerializeField] private MeshRenderer circleRenderer;
	[SerializeField] private Transform endCircleTransform;
	[SerializeField] private MeshRenderer endCircleRenderer;
	[SerializeField] private List<AudioClip> transitionClips;
	private Material bgMaterial;
	private Color defaultBgColor = Color.black;

	public override void Init()
	{
		if (circleTransform != null) circleTransform.localScale = Vector3.zero;
		if (endCircleTransform != null) endCircleTransform.localScale = Vector3.zero;
		if (circleRenderer != null) circleRenderer.enabled = false;
		if (endCircleRenderer != null) endCircleRenderer.enabled = false;
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = false;
		}
	}

	public override void PreBegin(Color? color)
	{
		Init();
	}

	public override IEnumerator Begin()
	{
		yield break;
	}

	public override void CleanUp()
	{
		Init();
	}

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		Init();
		yield break;
	}

	public override void InstantTransitionCover(Color? color)
	{
		Init();
	}
}
