using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000012")]
	public struct Vertex
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector3 position;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xC")]
		public readonly Vector3 normal;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x18")]
		public readonly Vector2 uv;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2A07D80", Offset = "0x2A07D80", VA = "0x2A07D80")]
		public Vertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
		}
	}
}
