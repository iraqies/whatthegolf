using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x200000B")]
	public struct TMP_Vertex
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 uv;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 uv2;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 uv4;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x24")]
		public Color32 color;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_Vertex k_Zero;
	}
}
