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

	public override void Init() { }
	public override void PreBegin(Color? color) { }

	public override IEnumerator Begin()
	{
		yield break;
	}

	public override void CleanUp() { }

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		yield break;
	}

	public override void InstantTransitionCover(Color? color) { }
}
