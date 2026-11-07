using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200002E")]
	public struct ReadOnlyNest2
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		public string readOnlyString;
	}
}
