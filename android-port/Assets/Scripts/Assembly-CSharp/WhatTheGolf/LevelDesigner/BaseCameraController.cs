using Cinemachine;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public abstract class BaseCameraController : MonoBehaviour
	{
		public abstract CinemachineVirtualCamera virtualCamera { get; }

		public abstract void SetActive(bool value);

		public abstract void SetTarget(Transform target);
	}
}
