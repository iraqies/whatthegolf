using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class SerializableSelectableData
	{
		[SerializeField]
		private int m_Id;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_Rotation;

		public int id => 0;

		public Vector3 position => default;

		public Vector3 rotation => default;

		public SerializableSelectableData(int id, Vector3 position, Vector3 rotation)
		{
		}
	}
}
