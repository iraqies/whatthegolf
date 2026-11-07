using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Serializable]
	[Token(Token = "0x200127D")]
	public class SelectableUnityEvents
	{
		[Token(Token = "0x4006364")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UnityEvent m_OnReset;

		[Token(Token = "0x4006365")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEvent m_OnEnterPlaymode;

		[Token(Token = "0x4006366")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent m_OnExitPlaymode;

		[Token(Token = "0x4006367")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent m_OnRemove;

		[Token(Token = "0x4006368")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ControllerUnityEvent m_OnSetBall;

		[Token(Token = "0x4006369")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GoalUnityEvent m_OnSetGoal;

		[Token(Token = "0x170009BF")]
		public UnityEvent OnReset
		{
			[Token(Token = "0x6005582")]
			[Address(RVA = "0x16892CC", Offset = "0x16892CC", VA = "0x16892CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C0")]
		public UnityEvent OnEnterPlaymode
		{
			[Token(Token = "0x6005583")]
			[Address(RVA = "0x16892D4", Offset = "0x16892D4", VA = "0x16892D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C1")]
		public UnityEvent OnExitPlaymode
		{
			[Token(Token = "0x6005584")]
			[Address(RVA = "0x16892DC", Offset = "0x16892DC", VA = "0x16892DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C2")]
		public UnityEvent OnRemove
		{
			[Token(Token = "0x6005585")]
			[Address(RVA = "0x16892E4", Offset = "0x16892E4", VA = "0x16892E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C3")]
		public ControllerUnityEvent OnSetBall
		{
			[Token(Token = "0x6005586")]
			[Address(RVA = "0x16892EC", Offset = "0x16892EC", VA = "0x16892EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C4")]
		public GoalUnityEvent OnSetGoal
		{
			[Token(Token = "0x6005587")]
			[Address(RVA = "0x16892F4", Offset = "0x16892F4", VA = "0x16892F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005588")]
		[Address(RVA = "0x16892FC", Offset = "0x16892FC", VA = "0x16892FC")]
		public SelectableUnityEvents()
		{
		}
	}
}
