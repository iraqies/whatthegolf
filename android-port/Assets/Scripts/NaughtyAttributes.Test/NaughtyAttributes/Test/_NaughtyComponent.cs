using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000048")]
	public class _NaughtyComponent : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		public bool flag0;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x19")]
		public bool flag1;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 slider0;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 slider1;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x22ABE34", Offset = "0x22ABE34", VA = "0x22ABE34")]
		public _NaughtyComponent()
		{
		}
	}
}
