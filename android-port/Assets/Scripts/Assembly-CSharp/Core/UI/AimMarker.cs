using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
	public class AimMarker : MonoBehaviour
	{
		public Vector3 Up;

		public Image Arrow;

		public Image Circle;

		public OverworldManager2d manager;

		public OverworldBallManager ballManager;

		private float DistanceToBallThreshold;

		private Coroutine routine;

		private GolfBallController controller;

		private void Start()
		{
		}

		private void OnLevelStarting(List<LevelData> levelDatas)
		{
		}

		public void OnGameStart(LevelData level)
		{
		}

		private void OnComplete(Level.CompletedState completedState)
		{
		}

		public void OnGameStop()
		{
		}

		public void SubscribeToController(GolfBallController newController)
		{
		}

		public void UnsubscribeToController()
		{
		}

		private void OnAimUpdate(Vector3 boost, bool isCancelled)
		{
		}

		private void Show()
		{
		}

		public void Hide()
		{
		}

		private void Hide(Vector3 v)
		{
		}

		private void Hide(string s)
		{
		}
	}
}
