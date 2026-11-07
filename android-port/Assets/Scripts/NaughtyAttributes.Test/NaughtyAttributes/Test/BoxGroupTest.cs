using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000002")]
	public class BoxGroupTest : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public int int0;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x1C")]
		public int int1;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		public float float0;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x24")]
		public float float1;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 slider0;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 slider1;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		public string str0;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x40")]
		public string str1;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x48")]
		public Transform trans0;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x50")]
		public Transform trans1;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x22AB60C", Offset = "0x22AB60C", VA = "0x22AB60C")]
		public BoxGroupTest()
		{
		}
	}
}
