using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200002C")]
	public class ReadOnlyTest : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x18")]
		public int readOnlyInt;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		public ReadOnlyNest1 nest1;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x22ABC54", Offset = "0x22ABC54", VA = "0x22ABC54")]
		public ReadOnlyTest()
		{
		}
	}
}
