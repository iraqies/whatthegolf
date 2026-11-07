using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class SelectableData
	{
		[SerializeField]
		private SelectableDefinition m_SelectableDefinition;

		[SerializeField]
		private Vector3 m_Position;

		[SerializeField]
		private Vector3 m_Rotation;

		public SelectableDefinition selectableDefinition => null;

		public Vector3 position => default;

		public Quaternion rotation => default;

		public SelectableData(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation)
		{
		}
	}
}
