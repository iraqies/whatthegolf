using GolfCourse;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	public class Goal : Selectable<GoalDefinition>
	{
		[SerializeField]
		private GolfGoal m_GolfGoal;

		[SerializeField]
		private GolfCoursePinGoal m_GolfCoursePinGoal;

		public GolfGoal golfGoal => null;

		public override Transform rootObject => null;

		public void Start()
		{
		}

		private void OnEnterPlayMode()
		{
		}

		private void OnExitPlayMode()
		{
		}
	}
}
