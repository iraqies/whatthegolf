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
			if (transitionEffects.Count > 0)
				lastUsedTransitionEffect = transitionEffects[0];
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
		if (defaultTextEffect != null)
		{
			defaultTextEffect.Initialize();
			if (defaultTextEffect is DefaultTransitionTextEffect dte)
				dte.HideImmidiate();
		}
		if (_textEffects != null)
		{
			foreach (var te in _textEffects)
			{
				if (te != null)
				{
					te.Initialize();
					if (te is DefaultTransitionTextEffect dte)
						dte.HideImmidiate();
				}
			}
		}
		textEffects = new TransitionTextEffects(_textEffects);
	}

	public void InstantTransitionCover(Color? color = null, BaseTransitionEffect transitionEffect = null)
	{
		if (transitionWorkingCoroutine != null)
		{
			StopCoroutine(transitionWorkingCoroutine);
			transitionWorkingCoroutine = null;
		}
		if (activeTransitionEffect == null)
			activeTransitionEffect = transitionEffect != null ? transitionEffect : lastUsedTransitionEffect;
		if (transitionCam != null)
			transitionCam.enabled = true;
		Color? actualColor = NextTransitionColor.HasValue ? NextTransitionColor : color;
		NextTransitionColor = null;
		activeTransitionEffect?.InstantTransitionCover(actualColor);
		SetInputAllowed(false);
		state = State.Loop;
	}

	public IEnumerator StartTransition(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		return StartTransitionInternalCR(textId, onTheSide, delay, onDone, color, textEffect, showWaitAnimation, isAsync, showWaitingText, transitionEffect, allowEndWhen);
	}

	private IEnumerator StartTransitionInternalCR(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		state = State.Start;
		if (transitionCam != null)
			transitionCam.enabled = true;

		activeTransitionEffect = transitionEffect != null ? transitionEffect : (lastUsedTransitionEffect ?? (transitionEffects != null && transitionEffects.Count > 0 ? transitionEffects[0] : null));
		Color? actualColor = NextTransitionColor.HasValue ? NextTransitionColor : color;
		NextTransitionColor = null;
		activeTransitionEffect?.PreBegin(actualColor);
		SetInputAllowed(false);

		if (waitAnimation != null)
			waitAnimation.SetActive(showWaitAnimation);
		if (waitText != null)
			waitText.SetActive(showWaitingText);

		if (!string.IsNullOrEmpty(textId))
		{
			if (textEffect == null)
				textEffect = defaultTextEffect;
			string display = Localization.Instance != null ? Localization.Instance.GetEnglishString(textId) : textId;
			if (string.IsNullOrEmpty(display))
				display = textId;
			activeTextEffect = textEffect;
			if (activeTextEffect != null)
			{
				activeTextEffect.gameObject.SetActive(true);
				activeTextEffect.Prepare(display, onTheSide);
				StartCoroutine(activeTextEffect.Show(transitionInDuration));
			}
			if (Localization.Instance != null && !Localization.Instance.IsEnglish())
			{
				string sub = Localization.Instance.GetString(textId, false, null);
				if (!string.IsNullOrEmpty(sub) && subtitles != null)
					subtitles.Show(textId, onTheSide);
			}
		}

		if (delay > 0f)
			yield return new WaitForSecondsRealtime(delay);

		if (activeTransitionEffect != null)
			yield return StartCoroutine(activeTransitionEffect.Begin());

		if (activeTextEffect != null)
		{
			while (activeTextEffect.IsBusy)
				yield return null;
		}
		if (allowEndWhen != null)
		{
			while (!allowEndWhen())
				yield return null;
		}

		state = State.Loop;
		onDone?.Invoke();
	}

	private void SetInputAllowed(bool allowed)
	{
		if (fullScreenUIBlocker != null)
			fullScreenUIBlocker.SetActive(!allowed);
	}

	public void EndTextTransitionImmidiate()
	{
		state = State.Idle;
		if (transitionWorkingCoroutine != null)
		{
			StopCoroutine(transitionWorkingCoroutine);
			transitionWorkingCoroutine = null;
		}
		if (activeTextEffect is DefaultTransitionTextEffect dte)
			dte.HideImmidiate();
		activeTextEffect = null;
		if (subtitles != null)
			subtitles.Hide();
		activeTransitionEffect?.CleanUp();
	}

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		return EndTransitionInternalCR(force, overrideTransitionDuration);
	}

	private IEnumerator EndTransitionInternalCR(bool force = false, float overrideTransitionDuration = 0f)
	{
		if (!IsShowing && !force)
		{
			if (transitionCam != null)
				transitionCam.enabled = false;
			yield break;
		}
		state = State.End;
		if (transitionCam != null)
			transitionCam.enabled = true;
		SetInputAllowed(true);

		float dur = overrideTransitionDuration > 0f ? overrideTransitionDuration : transitionOutDuration;
		if (activeTextEffect != null)
			StartCoroutine(activeTextEffect.Hide(dur));
		if (subtitles != null)
			subtitles.Hide();
		if (waitAnimation != null)
			waitAnimation.SetActive(false);
		if (waitText != null)
			waitText.SetActive(false);

		if (activeTransitionEffect != null)
			yield return StartCoroutine(activeTransitionEffect.End(dur));

		NextTransitionColor = null;
		if (activeTextEffect != null)
		{
			while (activeTextEffect.IsBusy)
				yield return null;
			activeTextEffect = null;
		}
		if (loopCoroutine != null)
		{
			StopCoroutine(loopCoroutine);
			loopCoroutine = null;
		}
		activeTransitionEffect?.CleanUp();
		if (transitionCam != null)
			transitionCam.enabled = false;
		state = State.Idle;
	}

	public bool IsTransitionRunning() => state != State.Idle;
}
