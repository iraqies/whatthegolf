using System.Collections.Generic;
using UnityEngine;
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

		private float DistanceToBallThreshold = 15f;
		private Coroutine routine;
		private GolfBallController controller;

		private void Awake()
		{
			Hide();
		}

		private void Start()
		{
			Hide();
		}

		private void OnLevelStarting(List<LevelData> levelDatas)
		{
			Hide();
		}

		public void OnGameStart(LevelData level)
		{
			Hide();
		}

		private void OnComplete(Level.CompletedState completedState)
		{
			Hide();
		}

		public void OnGameStop()
		{
			UnsubscribeToController();
			Hide();
		}

		public void SubscribeToController(GolfBallController newController)
		{
			UnsubscribeToController();
			controller = newController;
			if (controller != null)
			{
				controller.OnAimStart += Show;
				controller.OnAimUpdate += OnAimUpdate;
				controller.OnCancel += Hide;
				controller.OnShoot += Hide;
			}
		}

		public void UnsubscribeToController()
		{
			if (controller != null)
			{
				controller.OnAimStart -= Show;
				controller.OnAimUpdate -= OnAimUpdate;
				controller.OnCancel -= Hide;
				controller.OnShoot -= Hide;
				controller = null;
			}
		}

		private void OnAimUpdate(Vector3 boost, bool isCancelled)
		{
			if (isCancelled || boost.sqrMagnitude < 0.001f)
			{
				Hide();
				return;
			}
			Show();
		}

		private void Show()
		{
			if (Arrow != null) Arrow.enabled = true;
			if (Circle != null) Circle.enabled = true;
		}

		public void Hide()
		{
			if (Arrow != null) Arrow.enabled = false;
			if (Circle != null) Circle.enabled = false;
		}

		private void Hide(Vector3 v)
		{
			Hide();
		}

		private void Hide(string s)
		{
			Hide();
		}
	}
}
