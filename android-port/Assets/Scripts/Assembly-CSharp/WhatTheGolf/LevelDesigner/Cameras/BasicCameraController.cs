using Cinemachine;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Cameras
{
	public sealed class BasicCameraController : BaseCameraController
	{
		private CinemachineVirtualCamera m_VirtualCamera;

		public override CinemachineVirtualCamera virtualCamera => null;

		public override void SetActive(bool value)
		{
		}

		public override void SetTarget(Transform target)
		{
		}
	}
}
