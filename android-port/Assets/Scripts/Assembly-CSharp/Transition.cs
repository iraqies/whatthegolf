using System;
using System.Collections;
using System.Collections.Generic;
using CameraStack;
using UnityEngine;

public class Transition : MonoBehaviour
{
	public enum TransitionEffect
	{
		Default = 0,
		SportySports = 1,
		Snowy = 2,
		Hole = 3,
		Daily = 4,
		AmongUs = 5,
		Car = 6,
		SpecialDay = 7,
		Slime = 8,
		CustomPrefab = 9
	}

	private enum State
	{
		Idle = 0,
		Start = 1,
		Loop = 2,
		End = 3
	}

	[SerializeField]
	private GameObject fullScreenUIBlocker;

	[SerializeField]
	private TransitionTextEffect defaultTextEffect;

	[SerializeField]
	private List<TransitionTextEffect> _textEffects;

	[SerializeField]
	private TransitionSubtitles subtitles;

	[SerializeField]
	private GameObject waitAnimation;

	[SerializeField]
	private GameObject waitText;

	[SerializeField]
	public List<BaseTransitionEffect> transitionEffects;

	private BaseTransitionEffect lastUsedTransitionEffect;

	private SVGImage waitAnimationSpriteRenderer;

	private Color clearWhite;

	private TransitionTextEffects textEffects;

	private float transitionInDuration;

	private float transitionOutDuration;

	private Coroutine loopCoroutine;

	private State state;

	private TransitionTextEffect activeTextEffect;

	private BaseTransitionEffect activeTransitionEffect;

	private Camera transitionCam;

	private SecondDisplayCameraManager secondScreenCamera;

	private Coroutine transitionWorkingCoroutine;

	public Color? NextTransitionColor;

	public bool IsShowing => false;

	public TransitionTextEffects TextEffects => null;

	private void Awake()
	{
	}

	private void InitializeTransitionEffects()
	{
	}

	private void InitializeTextEffects()
	{
	}

	public void InstantTransitionCover(Color? color = null, BaseTransitionEffect transitionEffect = null)
	{
	}

	public IEnumerator StartTransition(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		return null;
	}

	private IEnumerator StartTransitionInternalCR(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		return null;
	}

	private void SetInputAllowed(bool allowed)
	{
	}

	public void EndTextTransitionImmidiate()
	{
	}

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	private IEnumerator EndTransitionInternalCR(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	public bool IsTransitionRunning()
	{
		return false;
	}
}
