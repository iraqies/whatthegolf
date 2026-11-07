using System;
using Il2CppDummyDll;
using UnityEngine;
using WhatTheGolf.LevelDesigner.GUI;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001248")]
	public class GuiGroup
	{
		[Token(Token = "0x4006288")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x4006289")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StateType[] m_StateMask;

		[Token(Token = "0x400628A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BaseGUI[] m_GuiPrefabs;

		[Token(Token = "0x400628B")]
		[FieldOffset(Offset = "0x28")]
		private Transform m_Container;

		[Token(Token = "0x400628C")]
		[FieldOffset(Offset = "0x30")]
		private BaseGUI[] m_Guis;

		[Token(Token = "0x17000976")]
		public StateType[] stateMask
		{
			[Token(Token = "0x600542E")]
			[Address(RVA = "0x14BEBC4", Offset = "0x14BEBC4", VA = "0x14BEBC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600542F")]
		[Address(RVA = "0x14BE278", Offset = "0x14BE278", VA = "0x14BE278")]
		public void Init(Camera camera)
		{
		}

		[Token(Token = "0x6005430")]
		[Address(RVA = "0x14BEB80", Offset = "0x14BEB80", VA = "0x14BEB80")]
		public void SetActive(bool value)
		{
		}

		[Token(Token = "0x6005431")]
		[Address(RVA = "0x14BE79C", Offset = "0x14BE79C", VA = "0x14BE79C")]
		public bool HasFocus()
		{
			return default;
		}

		[Token(Token = "0x6005432")]
		[Address(RVA = "0x14BEBCC", Offset = "0x14BEBCC", VA = "0x14BEBCC")]
		public GuiGroup()
		{
		}
	}
}
