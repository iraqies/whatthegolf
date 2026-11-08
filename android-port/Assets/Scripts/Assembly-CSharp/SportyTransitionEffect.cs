using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SportyTransitionEffect : BaseTransitionEffect
{
	[SerializeField] private Animator landscapeAnim;
	[SerializeField] private Animator portraitAnim;
	[SerializeField] private List<Renderer> landscapeRenders;
	[SerializeField] private List<Renderer> portraitRenders;
	[SerializeField] private ClipSettingsCollection transitionInClips;
	[SerializeField] private ClipSettingsCollection transitionOutClips;

	private string transitionIn;
	private string prepareIn;
	private string prepareOut;

	private List<Renderer> currentRenderers => landscapeRenders;
	private Animator anim => landscapeAnim;
	private bool usePortrait => false;

	public override void Init()
	{
		if (landscapeRenders != null)
		{
			foreach (var r in landscapeRenders)
				if (r != null) r.enabled = false;
		}
		if (portraitRenders != null)
		{
			foreach (var r in portraitRenders)
				if (r != null) r.enabled = false;
		}
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = false;
		}
		if (landscapeAnim != null) landscapeAnim.enabled = false;
		if (portraitAnim != null) portraitAnim.enabled = false;
	}

	public override void PreBegin(Color? color) => Init();

	public override IEnumerator Begin()
	{
		yield break;
	}

	public override void CleanUp() => Init();

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		Init();
		yield break;
	}

	public override void InstantTransitionCover(Color? color) => Init();
}
