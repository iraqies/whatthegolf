using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000019")]
	public class InfoBoxNest2
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x10")]
		public int error;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x22AB79C", Offset = "0x22AB79C", VA = "0x22AB79C")]
		public InfoBoxNest2()
		{
		}
	}
}
