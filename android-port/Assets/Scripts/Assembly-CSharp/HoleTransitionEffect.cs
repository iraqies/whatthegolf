using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HoleTransitionEffect : BaseTransitionEffect
{
	[SerializeField]
	private Renderer CirclePrefab;

	[SerializeField]
	private List<Color> colors;

	[SerializeField]
	private Renderer EndCircle;

	[SerializeField]
	private Transform Mask;

	[SerializeField]
	private AnimationCurve curve;

	[SerializeField]
	private float durationIn;

	[SerializeField]
	private float durationOut;

	[SerializeField]
	private int numRings;

	[SerializeField]
	private float maxSizeMobile;

	private float maxSizeDesktop;

	private List<Renderer> Circles;

	[SerializeField]
	private ClipSettingsCollection transitionInClips;

	[SerializeField]
	private ClipSettingsCollection transitionOutClips;

	[SerializeField]
	private float maxSize => 0f;

	private bool usePortrait => false;

	private void SetAllRenders(bool b)
	{
	}

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

	private IEnumerator FromTo(float from, float to)
	{
		return null;
	}

	public override void InstantTransitionCover(Color? color)
	{
	}

	private float tc(float input)
	{
		return 0f;
	}
}
