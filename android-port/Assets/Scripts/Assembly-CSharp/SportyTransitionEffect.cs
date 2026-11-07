using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SportyTransitionEffect : BaseTransitionEffect
{
	[SerializeField]
	private Animator landscapeAnim;

	[SerializeField]
	private Animator portraitAnim;

	[SerializeField]
	private List<Renderer> landscapeRenders;

	[SerializeField]
	private List<Renderer> portraitRenders;

	[SerializeField]
	private ClipSettingsCollection transitionInClips;

	[SerializeField]
	private ClipSettingsCollection transitionOutClips;

	private string transitionIn;

	private string prepareIn;

	private string prepareOut;

	private List<Renderer> currentRenderers => null;

	private Animator anim => null;

	private bool usePortrait => false;

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
