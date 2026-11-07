using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public class SelectableDefinition : ElementDefinition
	{
		[SerializeField]
		private GameObject m_Prefab;

		[SerializeField]
		private float m_HighlightRadius;

		[SerializeField]
		private float m_ScatterRadius;

		[SerializeField]
		private bool m_CanDelete;

		public GameObject prefab => null;

		public float highlightRadius => 0f;

		public float scatterRadius => 0f;

		public bool canDelete => false;
	}
}
