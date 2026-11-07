using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001245")]
	public sealed class MenuGUIData : ScriptableObject
	{
		[Token(Token = "0x4006277")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_CrownIcon;

		[Token(Token = "0x4006278")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_SearchIcon;

		[Token(Token = "0x4006279")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite m_PlayLevelIcon;

		[Token(Token = "0x400627A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite m_EditLevelIcon;

		[Token(Token = "0x400627B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color m_DefaultLabelColor;

		[Token(Token = "0x400627C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color m_DarkLabelColor;

		[Token(Token = "0x400627D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color m_SearchLabelColor;

		[Token(Token = "0x400627E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color m_FavoruiteLabelColor;

		[Token(Token = "0x1700096A")]
		public Sprite crownIcon
		{
			[Token(Token = "0x600541A")]
			[Address(RVA = "0x1564CEC", Offset = "0x1564CEC", VA = "0x1564CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700096B")]
		public Sprite searchIcon
		{
			[Token(Token = "0x600541B")]
			[Address(RVA = "0x1564CF4", Offset = "0x1564CF4", VA = "0x1564CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700096C")]
		public Sprite playLevelIcon
		{
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x1564CFC", Offset = "0x1564CFC", VA = "0x1564CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700096D")]
		public Sprite editLevelIcon
		{
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x1564D04", Offset = "0x1564D04", VA = "0x1564D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700096E")]
		public Color defaultLabelColor
		{
			[Token(Token = "0x600541E")]
			[Address(RVA = "0x1564D0C", Offset = "0x1564D0C", VA = "0x1564D0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700096F")]
		public Color darkLabelColor
		{
			[Token(Token = "0x600541F")]
			[Address(RVA = "0x1564D18", Offset = "0x1564D18", VA = "0x1564D18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000970")]
		public Color searchLabelColor
		{
			[Token(Token = "0x6005420")]
			[Address(RVA = "0x1564D24", Offset = "0x1564D24", VA = "0x1564D24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000971")]
		public Color favouriteLabelColor
		{
			[Token(Token = "0x6005421")]
			[Address(RVA = "0x1564D30", Offset = "0x1564D30", VA = "0x1564D30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005422")]
		[Address(RVA = "0x1564D3C", Offset = "0x1564D3C", VA = "0x1564D3C")]
		public MenuGUIData()
		{
		}
	}
}
