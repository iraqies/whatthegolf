using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SuperPuttTransitionTextEffect : TransitionTextEffect
{
	[Serializable]
	public class SuperPuttEffect
	{
		public string Text;

		public float Duration;

		public List<AudioClip> Clip;

		public float Volume;
	}

	public List<SuperPuttEffect> Messages;

	public TextMeshProUGUI Text;

	public bool TestSequence;

	private bool isBusy;

	private CanvasScaler canvasScaler;

	private RectTransform rootTransform;

	private int repeats;

	public override bool IsBusy => false;

	private void Awake()
	{
	}

	public override void Initialize()
	{
	}

	public override void Prepare(string text = null, bool onTheSide = false)
	{
	}

	public override IEnumerator Show(float transitionInDuration)
	{
		return null;
	}

	public override IEnumerator Hide(float transitionOutDuration)
	{
		return null;
	}
}
