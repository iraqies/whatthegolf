using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Serializable]
	[Token(Token = "0x200127F")]
	public class GoalUnityEvent : UnityEvent<GolfGoal>
	{
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x148EFC4", Offset = "0x148EFC4", VA = "0x148EFC4")]
		public GoalUnityEvent()
		{
		}
	}
}
