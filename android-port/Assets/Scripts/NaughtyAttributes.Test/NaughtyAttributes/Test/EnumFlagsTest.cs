using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200000E")]
	public class EnumFlagsTest : MonoBehaviour
	{
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		public TestEnum flags0;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		public EnumFlagsNest1 nest1;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x22AB74C", Offset = "0x22AB74C", VA = "0x22AB74C")]
		public EnumFlagsTest()
		{
		}
	}
}
