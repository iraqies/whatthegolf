using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001246")]
	public sealed class OptionsGUIData : ScriptableObject
	{
		[Token(Token = "0x400627F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_PlayIcon;

		[Token(Token = "0x4006280")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_PauseIcon;

		[Token(Token = "0x17000972")]
		public Sprite playIcon
		{
			[Token(Token = "0x6005423")]
			[Address(RVA = "0x159D478", Offset = "0x159D478", VA = "0x159D478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000973")]
		public Sprite pauseIcon
		{
			[Token(Token = "0x6005424")]
			[Address(RVA = "0x159D480", Offset = "0x159D480", VA = "0x159D480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005425")]
		[Address(RVA = "0x159D488", Offset = "0x159D488", VA = "0x159D488")]
		public OptionsGUIData()
		{
		}
	}
}
