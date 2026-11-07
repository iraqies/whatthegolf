using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	[Token(Token = "0x20010F3")]
	public struct QuaternionSerializer
	{
		[Token(Token = "0x4005942")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4005943")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4005944")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4005945")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		[NonSerialized]
		[Token(Token = "0x4005946")]
		[FieldOffset(Offset = "0x10")]
		private Quaternion rotation;

		[NonSerialized]
		[Token(Token = "0x4005947")]
		[FieldOffset(Offset = "0x20")]
		private bool isSet;

		[Token(Token = "0x17000807")]
		public Quaternion Q
		{
			[Token(Token = "0x6004BD3")]
			[Address(RVA = "0x1632740", Offset = "0x1632740", VA = "0x1632740")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x1632724", Offset = "0x1632724", VA = "0x1632724")]
		public void Fill(Quaternion q)
		{
		}
	}
}
