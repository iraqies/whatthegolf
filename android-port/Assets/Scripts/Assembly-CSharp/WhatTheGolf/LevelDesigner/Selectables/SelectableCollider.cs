using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	public class SelectableCollider : MonoBehaviour
	{
		private Collider m_Collider;

		[SerializeField]
		private Selectable m_Selectable;

		public Collider collider => null;

		public Selectable selectable => null;

		private void Start()
		{
		}

		private void OnExitPlayMode()
		{
		}

		private void OnEnterPlayMode()
		{
		}
	}
}
