using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTransitionEffect : BaseTransitionEffect
{
	[SerializeField]
	private Transform circleTransform;

	[SerializeField]
	private MeshRenderer circleRenderer;

	[SerializeField]
	private Transform endCircleTransform;

	[SerializeField]
	private MeshRenderer endCircleRenderer;

	[SerializeField]
	private List<AudioClip> transitionClips;

	private Material bgMaterial;

	private Color defaultBgColor;

	private const float transitionInDuration = 0.4f;

	private const float transitionOutDuration = 0.4f;

	private const float circleMaxScale = 0.006939388f;

	private const float endCircleMinScale = 0.002055002f;

	private const float endCircleMaxScale = 0.5123225f;

	public override void Init()
	{
	}

	public override void PreBegin(Color? color)
	{
	}

	public override IEnumerator Begin()
	{
		return null;
	}

	public override void CleanUp()
	{
	}

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		return null;
	}

	public override void InstantTransitionCover(Color? color)
	{
	}
}
