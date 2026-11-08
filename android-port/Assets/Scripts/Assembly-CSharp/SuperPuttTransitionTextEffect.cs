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

	public override bool IsBusy => isBusy;

	private void Awake()
	{
		gameObject.SetActive(false);
	}

	public override void Initialize()
	{
		isBusy = false;
		gameObject.SetActive(false);
	}

	public override void Prepare(string text = null, bool onTheSide = false)
	{
	}

	public override IEnumerator Show(float transitionInDuration)
	{
		yield break;
	}

	public override IEnumerator Hide(float transitionOutDuration)
	{
		isBusy = false;
		gameObject.SetActive(false);
		yield break;
	}
}
