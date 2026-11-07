using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public class SceneNest1
	{
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		public string scene1;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x18")]
		public SceneNest2 nest2;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x22ABC9C", Offset = "0x22ABC9C", VA = "0x22ABC9C")]
		public SceneNest1()
		{
		}
	}
}
