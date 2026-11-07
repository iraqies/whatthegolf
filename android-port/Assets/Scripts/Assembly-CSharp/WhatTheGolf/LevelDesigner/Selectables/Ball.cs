using Core;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	public class Ball : Selectable<BallDefinition>
	{
		[SerializeField]
		private GolfBallController m_Controller;

		[SerializeField]
		private Transform m_CameraTarget;

		private const float kMaxBallDistanceFromOrigin = 1000f;

		private bool m_PlayMode;

		private Transform m_targetFollower;

		public GolfBallController controller => null;

		public Transform cameraTarget => null;

		public virtual void Start()
		{
		}

		public virtual void Update()
		{
		}

		private void OnExitPlayMode()
		{
		}

		private void OnEnterPlayMode()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
