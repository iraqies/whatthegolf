using System;
using System.Collections;
using System.Collections.Generic;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Core.UI
{
	public class AimMarker : MonoBehaviour
	{
		public Vector3 Up = Vector3.up;
		public Image Arrow;
		public Image Circle;
		public OverworldManager2d manager;
		public OverworldBallManager ballManager;

		private float DistanceToBallThreshold = 0.08f;
		private Coroutine routine;
		private GolfBallController controller;

		private void Start()
		{
			var ps = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			if (ps == null || !ps.UseAimMarker)
			{
				gameObject.SetActive(false);
				return;
			}
			gameObject.SetActive(false);
			if (manager != null)
			{
				manager.OnLevelStarting -= OnLevelStarting;
				manager.OnLevelStarting += OnLevelStarting;
				if (ballManager != null)
				{
					ballManager.OnNewBall -= OnNewBall;
					ballManager.OnNewBall += OnNewBall;
				}
				if (manager.ball != null)
					SubscribeToController(manager.ball.GetComponent<GolfBallController>());
			}
			else if (LevelManager.Exists)
			{
				LevelManager.Instance.OnLevelLoaded -= OnGameStart;
				LevelManager.Instance.OnLevelLoaded += OnGameStart;
				LevelManager.Instance.OnLevelWillUnload -= OnGameStop;
				LevelManager.Instance.OnLevelWillUnload += OnGameStop;
			}
		}

		private void OnNewBall(Transmogrif.BALLSHAPES shape)
		{
			if (ballManager != null && ballManager.Ball != null)
				SubscribeToController(ballManager.Ball.GetComponent<GolfBallController>());
		}

		private void OnLevelStarting(List<LevelData> levelDatas)
		{
			gameObject.SetActive(false);
		}

		public void OnGameStart(LevelData level)
		{
			gameObject.SetActive(false);
			if (Level.Instance != null)
			{
				SubscribeToController(Level.Instance.Ball);
				Level.Instance.OnComplete -= OnComplete;
				Level.Instance.OnComplete += OnComplete;
			}
		}

		private void OnComplete(Level.CompletedState completedState)
		{
			gameObject.SetActive(false);
		}

		public void OnGameStop()
		{
			gameObject.SetActive(false);
			UnsubscribeToController();
			if (Level.Instance != null)
				Level.Instance.OnComplete -= OnComplete;
		}

		public void SubscribeToController(GolfBallController newController)
		{
			var ps = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			if (ps == null || !ps.UseAimMarker)
				return;
			UnsubscribeToController();
			controller = newController;
			if (controller == null)
				return;
			controller.OnAimStart += Show;
			controller.OnAimUpdate += OnAimUpdate;
			controller.OnShoot += Hide;
			controller.OnReset += Hide;
			controller.OnCancel += Hide;
		}

		public void UnsubscribeToController()
		{
			if (controller == null)
				return;
			controller.OnAimStart -= Show;
			controller.OnAimUpdate -= OnAimUpdate;
			controller.OnShoot -= Hide;
			controller.OnReset -= Hide;
			controller.OnCancel -= Hide;
			controller = null;
		}

		private void OnAimUpdate(Vector3 boost, bool isCancelled)
		{
			if (controller == null)
				return;
			Vector2 startMouse = controller.StartAimMousePosition;
			transform.position = new Vector3(startMouse.x, startMouse.y, 0f);
			Vector2 mousePos = Input.mousePosition;
			Vector2 dir = (startMouse - mousePos).normalized;
			if (new Vector3(dir.x, dir.y, 0f) != Vector3.zero)
			{
				transform.rotation = Quaternion.LookRotation(new Vector3(dir.x, dir.y, 0f), Vector3.right);
			}
			Camera cam = Camera.main;
			if (cam == null)
				return;
			Vector2 ballScreen = cam.WorldToScreenPoint(controller.transform.position);
			float dist = Vector2.Distance(ballScreen, startMouse);
			float mag = boost.magnitude;
			if (Circle != null)
			{
				float s = Mathf.SmoothStep(1f, 0.5f, TweenFunctions.EaseOut(TweenFunctions.EaseOut(mag)));
				Circle.transform.localScale = Vector3.one * s;
			}
			bool showMarker = (dist / Mathf.Max(1, Screen.width)) > DistanceToBallThreshold && !isCancelled;
			if (Arrow != null)
				Arrow.color = new Color(1f, 1f, 1f, showMarker ? 1f : 0f);
			if (Circle != null)
				Circle.color = new Color(1f, 1f, 1f, showMarker ? Mathf.Lerp(1f, 0.5f, mag) : 0f);
		}

		private void Show()
		{
			if (ReInput.controllers != null && ReInput.controllers.GetLastActiveControllerType() == ControllerType.Joystick)
			{
				gameObject.SetActive(true);
				if (routine != null)
					StopCoroutine(routine);
				if (gameObject.activeInHierarchy)
				{
					routine = StartCoroutine(pTween.ToRealTime(0.1f, t =>
					{
						transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, Mathf.Clamp01(TweenFunctions.EaseOut(t)));
					}));
				}
			}
			else
			{
				gameObject.SetActive(false);
			}
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}

		private void Hide(Vector3 v)
		{
			gameObject.SetActive(false);
		}

		private void Hide(string s)
		{
			gameObject.SetActive(false);
		}
	}
}
