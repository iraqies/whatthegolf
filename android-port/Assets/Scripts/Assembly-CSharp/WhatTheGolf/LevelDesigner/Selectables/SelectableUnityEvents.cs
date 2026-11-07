using System;
using UnityEngine;
using UnityEngine.Events;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Serializable]
	public class SelectableUnityEvents
	{
		[SerializeField]
		private UnityEvent m_OnReset;

		[SerializeField]
		private UnityEvent m_OnEnterPlaymode;

		[SerializeField]
		private UnityEvent m_OnExitPlaymode;

		[SerializeField]
		private UnityEvent m_OnRemove;

		[SerializeField]
		private ControllerUnityEvent m_OnSetBall;

		[SerializeField]
		private GoalUnityEvent m_OnSetGoal;

		public UnityEvent OnReset => null;

		public UnityEvent OnEnterPlaymode => null;

		public UnityEvent OnExitPlaymode => null;

		public UnityEvent OnRemove => null;

		public ControllerUnityEvent OnSetBall => null;

		public GoalUnityEvent OnSetGoal => null;
	}
}
