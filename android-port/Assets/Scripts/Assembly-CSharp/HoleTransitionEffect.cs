using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HoleTransitionEffect : BaseTransitionEffect
{
	[SerializeField] private Renderer CirclePrefab;
	[SerializeField] private List<Color> colors;
	[SerializeField] private Renderer EndCircle;
	[SerializeField] private Transform Mask;
	[SerializeField] private AnimationCurve curve;
	[SerializeField] private float durationIn;
	[SerializeField] private float durationOut;
	[SerializeField] private int numRings;
	[SerializeField] private float maxSizeMobile;
	private float maxSizeDesktop;
	private List<Renderer> Circles;
	[SerializeField] private ClipSettingsCollection transitionInClips;
	[SerializeField] private ClipSettingsCollection transitionOutClips;

	[SerializeField] private float maxSize => maxSizeMobile;
	private bool usePortrait => false;

	private void SetAllRenders(bool b)
	{
		if (CirclePrefab != null) CirclePrefab.enabled = b;
		if (EndCircle != null) EndCircle.enabled = b;
		if (Circles != null)
		{
			foreach (var r in Circles)
				if (r != null) r.enabled = b;
		}
		foreach (var r in GetComponentsInChildren<Renderer>(true))
		{
			if (r != null) r.enabled = b;
		}
	}

	public override void Init()
	{
		SetAllRenders(false);
		if (Mask != null) Mask.localScale = Vector3.zero;
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

	private IEnumerator FromTo(float from, float to)
	{
		yield break;
	}

	public override void InstantTransitionCover(Color? color) => Init();

	private float tc(float input) => curve != null ? curve.Evaluate(input) : input;
}
