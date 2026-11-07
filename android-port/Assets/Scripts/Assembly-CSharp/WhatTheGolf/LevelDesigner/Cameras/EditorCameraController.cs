using Cinemachine;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Cameras
{
	public sealed class EditorCameraController : BaseCameraController
	{
		[SerializeField]
		private CinemachineVirtualCamera m_VirtualCamera;

		[SerializeField]
		private float m_MinZoom;

		[SerializeField]
		private float m_MaxZoom;

		[SerializeField]
		private float m_ZoomSpeed;

		[SerializeField]
		private AnimationCurve m_ZoomSpeedCurve;

		private const string kZoomInput = "Mouse ScrollWheel";

		private const float kPanSpeedMouse = 0.05f;

		private const float kRotateSpeedMouse = 0.1f;

		private bool m_HasInput;

		public override CinemachineVirtualCamera virtualCamera => null;

		public override void SetActive(bool value)
		{
		}

		public override void SetTarget(Transform target)
		{
		}

		private void Update()
		{
		}
	}
}
