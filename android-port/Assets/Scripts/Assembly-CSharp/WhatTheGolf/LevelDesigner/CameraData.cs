using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class CameraData
	{
		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_Rotation;

		public Vector3 position => default;

		public Quaternion rotation => default;
	}
}
