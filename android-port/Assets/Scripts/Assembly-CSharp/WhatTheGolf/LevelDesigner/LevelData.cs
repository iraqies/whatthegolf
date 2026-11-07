using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001232")]
	public sealed class LevelData : ScriptableObject
	{
		[Token(Token = "0x400624F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_LevelName;

		[Token(Token = "0x4006250")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_Description;

		[Token(Token = "0x4006251")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D m_Thumbnail;

		[Token(Token = "0x4006252")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LevelContentData m_ContentData;

		[Token(Token = "0x4006253")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_CanPublish;

		[Token(Token = "0x4006254")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool m_Published;

		[Token(Token = "0x4006255")]
		[FieldOffset(Offset = "0x3C")]
		private Guid m_Guid;

		[Token(Token = "0x4006256")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_Completed;

		[Token(Token = "0x4006257")]
		[FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5884C", Offset = "0x5884C")]
		private bool hasUnsavedChanges__BackingField;

		[Token(Token = "0x17000946")]
		public string levelName
		{
			[Token(Token = "0x60053CE")]
			[Address(RVA = "0x1529228", Offset = "0x1529228", VA = "0x1529228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053CF")]
			[Address(RVA = "0x1529230", Offset = "0x1529230", VA = "0x1529230")]
			set
			{
			}
		}

		[Token(Token = "0x17000947")]
		public string description
		{
			[Token(Token = "0x60053D0")]
			[Address(RVA = "0x1529238", Offset = "0x1529238", VA = "0x1529238")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D1")]
			[Address(RVA = "0x1529240", Offset = "0x1529240", VA = "0x1529240")]
			set
			{
			}
		}

		[Token(Token = "0x17000948")]
		public Texture2D thumbnail
		{
			[Token(Token = "0x60053D2")]
			[Address(RVA = "0x1529248", Offset = "0x1529248", VA = "0x1529248")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D3")]
			[Address(RVA = "0x1529250", Offset = "0x1529250", VA = "0x1529250")]
			set
			{
			}
		}

		[Token(Token = "0x17000949")]
		public LevelContentData contentData
		{
			[Token(Token = "0x60053D4")]
			[Address(RVA = "0x1529258", Offset = "0x1529258", VA = "0x1529258")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0x1529260", Offset = "0x1529260", VA = "0x1529260")]
			set
			{
			}
		}

		[Token(Token = "0x1700094A")]
		public bool canPublish
		{
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0x1529268", Offset = "0x1529268", VA = "0x1529268")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0x1529270", Offset = "0x1529270", VA = "0x1529270")]
			set
			{
			}
		}

		[Token(Token = "0x1700094B")]
		public bool published
		{
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0x1529278", Offset = "0x1529278", VA = "0x1529278")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053D9")]
			[Address(RVA = "0x1529280", Offset = "0x1529280", VA = "0x1529280")]
			set
			{
			}
		}

		[Token(Token = "0x1700094C")]
		public Guid guid
		{
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0x1529288", Offset = "0x1529288", VA = "0x1529288")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0x1529298", Offset = "0x1529298", VA = "0x1529298")]
			set
			{
			}
		}

		[Token(Token = "0x1700094D")]
		public bool completed
		{
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0x15292A4", Offset = "0x15292A4", VA = "0x15292A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0x15292AC", Offset = "0x15292AC", VA = "0x15292AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700094E")]
		public bool hasUnsavedChanges
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0x15292B4", Offset = "0x15292B4", VA = "0x15292B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x711B8", Offset = "0x711B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0x15292BC", Offset = "0x15292BC", VA = "0x15292BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x711C8", Offset = "0x711C8")]
			set
			{
			}
		}

		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x15292C4", Offset = "0x15292C4", VA = "0x15292C4")]
		public LevelData()
		{
		}
	}
}
