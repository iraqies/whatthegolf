using System;
using Il2CppDummyDll;

namespace Triband.BuildPipeline
{
	[Serializable]
	[Token(Token = "0x2000007")]
	public class ConfigurableVariable
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public ConfigurableAddress address;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		public ConfigurableValue value;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x29F7648", Offset = "0x29F7648", VA = "0x29F7648")]
		public ConfigurableVariable()
		{
		}
	}
}
