using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000044")]
	public struct TagNest2
	{
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		public string tag2;
	}
}
