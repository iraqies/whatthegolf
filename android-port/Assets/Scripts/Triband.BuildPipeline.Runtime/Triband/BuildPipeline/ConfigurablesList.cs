using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Triband.BuildPipeline
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public class ConfigurablesList
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1AF2E0", Offset = "0x1AF2E0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1AF2E0", Offset = "0x1AF2E0")]
		public List<ConfigurableVariable> variables;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x29F76B4", Offset = "0x29F76B4", VA = "0x29F76B4")]
		public ConfigurablesList()
		{
		}
	}
}
