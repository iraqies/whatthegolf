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
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static void ShowThrobber(float duration = 1f)
	{
	}

	public static void HideThrobber()
	{
	}

	public static void PreLoad()
	{
	}

	private static void LoadAndInvoke(Action callback)
	{
	}

	private void ShowIt(float duration = 1f)
	{
	}

	private void Hide()
	{
	}

	private void SetObjectsActive(bool state)
	{
	}

	public void Show()
	{
	}
}
