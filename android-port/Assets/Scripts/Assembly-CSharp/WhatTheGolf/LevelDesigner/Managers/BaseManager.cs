using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public abstract class BaseManager : MonoBehaviour
	{
		private MainController m_Owner;

		public MainController owner
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public abstract void Init();
	}
}
