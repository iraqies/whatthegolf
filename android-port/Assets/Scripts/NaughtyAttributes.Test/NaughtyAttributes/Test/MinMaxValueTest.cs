using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000023")]
	public class MinMaxValueTest : MonoBehaviour
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		public int min0;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x1C")]
		public int max0;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		public float range01;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		public MinMaxValueNest1 nest1;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x22AB898", Offset = "0x22AB898", VA = "0x22AB898")]
		public MinMaxValueTest()
		{
		}
	}
}
