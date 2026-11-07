using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[Token(Token = "0x200038B")]
	public struct ScreenRect
	{
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x0")]
		public float xMin;

		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x4")]
		public float yMin;

		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x8")]
		public float width;

		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0xC")]
		public float height;

		[Token(Token = "0x1700072E")]
		public float xMax
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x23FB674", Offset = "0x23FB674", VA = "0x23FB674")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700072F")]
		public float yMax
		{
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x23FB684", Offset = "0x23FB684", VA = "0x23FB684")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000730")]
		public Vector2 center
		{
			[Token(Token = "0x6001B6E")]
			[Address(RVA = "0x23F9BCC", Offset = "0x23F9BCC", VA = "0x23F9BCC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x23FB694", Offset = "0x23FB694", VA = "0x23FB694")]
		public ScreenRect(float P_0, float P_1, float P_2, float P_3)
		{
		}

		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x240BC78", Offset = "0x240BC78", VA = "0x240BC78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
