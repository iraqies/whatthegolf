using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Token(Token = "0x2001272")]
	public class Goal : Selectable<GoalDefinition>
	{
		[Token(Token = "0x400632A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GolfGoal m_GolfGoal;

		[Token(Token = "0x400632B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GolfCoursePinGoal m_GolfCoursePinGoal;

		[Token(Token = "0x170009AA")]
		public GolfGoal golfGoal
		{
			[Token(Token = "0x600553A")]
			[Address(RVA = "0x148ED54", Offset = "0x148ED54", VA = "0x148ED54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AB")]
		public override Transform rootObject
		{
			[Token(Token = "0x600553B")]
			[Address(RVA = "0x148EE00", Offset = "0x148EE00", VA = "0x148EE00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600553C")]
		[Address(RVA = "0x148EE08", Offset = "0x148EE08", VA = "0x148EE08")]
		public void Start()
		{
		}

		[Token(Token = "0x600553D")]
		[Address(RVA = "0x148EF24", Offset = "0x148EF24", VA = "0x148EF24")]
		private void OnEnterPlayMode()
		{
		}

		[Token(Token = "0x600553E")]
		[Address(RVA = "0x148EF44", Offset = "0x148EF44", VA = "0x148EF44")]
		private void OnExitPlayMode()
		{
		}

		[Token(Token = "0x600553F")]
		[Address(RVA = "0x148EF64", Offset = "0x148EF64", VA = "0x148EF64")]
		public Goal()
		{
		}
	}
}
