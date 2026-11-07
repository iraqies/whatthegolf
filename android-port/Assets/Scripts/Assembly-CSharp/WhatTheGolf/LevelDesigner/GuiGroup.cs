using System;
using UnityEngine;
using WhatTheGolf.LevelDesigner.GUI;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class GuiGroup
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private StateType[] m_StateMask;

		[SerializeField]
		private BaseGUI[] m_GuiPrefabs;

		private Transform m_Container;

		private BaseGUI[] m_Guis;

		public StateType[] stateMask => null;

		public void Init(Camera camera)
		{
		}

		public void SetActive(bool value)
		{
		}

		public bool HasFocus()
		{
			return false;
		}
	}
}
