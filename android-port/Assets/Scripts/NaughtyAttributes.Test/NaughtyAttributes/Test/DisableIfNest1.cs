using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000005")]
	public class DisableIfNest1
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		public bool disable1;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x11")]
		public bool disable2;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x14")]
		public int disableIfAll;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		public int disableIfAny;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		public DisableIfNest2 nest2;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x22AB63C", Offset = "0x22AB63C", VA = "0x22AB63C")]
		public DisableIfNest1()
		{
		}
	}
}
