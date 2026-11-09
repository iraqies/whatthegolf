using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveThrobber : SingletonBehaviour<SaveThrobber>
{
	public const float Rotationspeed = 7f;

	public const float DoorDuration = 0.5f;

	private Canvas _holderCanvas;

	private Animator _animator;

	private float _displayDuration;

	private float _timeLeft;

	private bool _displaying;

	private static bool _isLoading;

	private static Action _callbacks;

	private static Scene activeScene;

	protected override void OnAwake()
	{
		_holderCanvas = GetComponentInChildren<Canvas>(true);
		_animator = GetComponentInChildren<Animator>(true);
		SetObjectsActive(false);
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
		if (!_displaying) return;
		_timeLeft -= Time.unscaledDeltaTime;
		if (_timeLeft <= 0f)
			Hide();
	}

	public static void ShowThrobber(float duration = 1f)
	{
		if (Instance != null)
			Instance.ShowIt(duration);
	}

	public static void HideThrobber()
	{
		if (Instance != null)
			Instance.Hide();
	}

	public static void PreLoad()
	{
	}

	private static void LoadAndInvoke(Action callback)
	{
		callback?.Invoke();
	}

	private void ShowIt(float duration = 1f)
	{
		_displayDuration = duration;
		_timeLeft = duration;
		_displaying = true;
		SetObjectsActive(true);
	}

	private void Hide()
	{
		_displaying = false;
		SetObjectsActive(false);
	}

	private void SetObjectsActive(bool state)
	{
		if (_holderCanvas != null)
			_holderCanvas.enabled = state;
	}

	public void Show()
	{
		ShowIt(1f);
	}
}
