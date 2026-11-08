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

	[SerializeField] private GameObject fullScreenUIBlocker;
	[SerializeField] private TransitionTextEffect defaultTextEffect;
	[SerializeField] private List<TransitionTextEffect> _textEffects = new List<TransitionTextEffect>();
	[SerializeField] private TransitionSubtitles subtitles;
	[SerializeField] private GameObject waitAnimation;
	[SerializeField] private GameObject waitText;
	[SerializeField] public List<BaseTransitionEffect> transitionEffects = new List<BaseTransitionEffect>();

	private BaseTransitionEffect lastUsedTransitionEffect;
	private SVGImage waitAnimationSpriteRenderer;
	private Color clearWhite = new Color(1f, 1f, 1f, 0f);
	private TransitionTextEffects textEffects;
	private float transitionInDuration = 0.25f;
	private float transitionOutDuration = 0.25f;
	private Coroutine loopCoroutine;
	private State state = State.Idle;
	private TransitionTextEffect activeTextEffect;
	private BaseTransitionEffect activeTransitionEffect;
	private Camera transitionCam;
	private SecondDisplayCameraManager secondScreenCamera;
	private Coroutine transitionWorkingCoroutine;
	public Color? NextTransitionColor;

	public bool IsShowing => state != State.Idle;
	public TransitionTextEffects TextEffects => textEffects ?? (textEffects = new TransitionTextEffects(_textEffects));

	private void Awake()
	{
		transitionCam = GetComponent<Camera>();
		if (transitionCam != null)
			transitionCam.enabled = false;
		if (waitAnimation != null)
		{
			waitAnimation.SetActive(false);
			waitAnimationSpriteRenderer = waitAnimation.GetComponentInChildren<SVGImage>(true);
		}
		if (waitText != null)
			waitText.SetActive(false);
		if (fullScreenUIBlocker != null)
			fullScreenUIBlocker.SetActive(false);
		if (subtitles != null)
			subtitles.Hide();
		InitializeTransitionEffects();
		InitializeTextEffects();
	}

	private void InitializeTransitionEffects()
	{
		if (transitionEffects != null)
		{
			foreach (var e in transitionEffects)
			{
				if (e != null)
				{
					e.Init();
					e.CleanUp();
				}
			}
		}
		foreach (var e in GetComponentsInChildren<BaseTransitionEffect>(true))
		{
			if (e != null)
			{
				e.Init();
				e.CleanUp();
			}
		}
	}

	private void InitializeTextEffects()
	{
		textEffects = new TransitionTextEffects(_textEffects);
		if (defaultTextEffect != null)
		{
			defaultTextEffect.Initialize();
			defaultTextEffect.gameObject.SetActive(false);
		}
		if (_textEffects != null)
		{
			foreach (var te in _textEffects)
			{
				if (te != null)
				{
					te.Initialize();
					te.gameObject.SetActive(false);
				}
			}
		}
		foreach (var te in GetComponentsInChildren<TransitionTextEffect>(true))
		{
			if (te != null)
			{
				te.Initialize();
				te.gameObject.SetActive(false);
			}
		}
	}

	public void InstantTransitionCover(Color? color = null, BaseTransitionEffect transitionEffect = null)
	{
		state = State.Idle;
		if (transitionCam != null)
			transitionCam.enabled = false;
		if (fullScreenUIBlocker != null)
			fullScreenUIBlocker.SetActive(false);
	}

	public IEnumerator StartTransition(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		state = State.Start;
		if (delay > 0f)
			yield return new WaitForSecondsRealtime(Mathf.Min(delay, 0.25f));
		state = State.Loop;
		onDone?.Invoke();
	}

	private IEnumerator StartTransitionInternalCR(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		return StartTransition(textId, onTheSide, delay, onDone, color, textEffect, showWaitAnimation, isAsync, showWaitingText, transitionEffect, allowEndWhen);
	}

	private void SetInputAllowed(bool allowed) { }

	public void EndTextTransitionImmidiate()
	{
		InitializeTextEffects();
		if (subtitles != null) subtitles.Hide();
	}

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		state = State.Idle;
		InitializeTransitionEffects();
		InitializeTextEffects();
		if (subtitles != null)
			subtitles.Hide();
		if (waitAnimation != null)
			waitAnimation.SetActive(false);
		if (waitText != null)
			waitText.SetActive(false);
		if (fullScreenUIBlocker != null)
			fullScreenUIBlocker.SetActive(false);
		if (transitionCam != null)
			transitionCam.enabled = false;
		yield break;
	}

	private IEnumerator EndTransitionInternalCR(bool force = false, float overrideTransitionDuration = 0f)
	{
		return EndTransition(force, overrideTransitionDuration);
	}

	public bool IsTransitionRunning() => state != State.Idle;
}
