using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	[Token(Token = "0x2000009")]
	public sealed class TerrainLayer
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_IsEnabled;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_LayerName;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlendMode m_BlendMode;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private byte[] m_Values;

		[Token(Token = "0x17000021")]
		public bool isEnabled
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x29FEDE0", Offset = "0x29FEDE0", VA = "0x29FEDE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		public BlendMode blendMode
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x29FEDE8", Offset = "0x29FEDE8", VA = "0x29FEDE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public byte[] values
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x29FEDF0", Offset = "0x29FEDF0", VA = "0x29FEDF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x29FEDF8", Offset = "0x29FEDF8", VA = "0x29FEDF8")]
			set
			{
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x29FB640", Offset = "0x29FB640", VA = "0x29FB640")]
		public TerrainLayer()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x29FB6A8", Offset = "0x29FB6A8", VA = "0x29FB6A8")]
		public void Init(int pointCount)
		{
		}
	}
}
