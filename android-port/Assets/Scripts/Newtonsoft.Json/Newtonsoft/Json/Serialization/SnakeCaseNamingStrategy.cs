using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C6")]
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x23228E4", Offset = "0x23228E4", VA = "0x23228E4")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2322920", Offset = "0x2322920", VA = "0x2322920")]
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2322964", Offset = "0x2322964", VA = "0x2322964")]
		public SnakeCaseNamingStrategy()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x232296C", Offset = "0x232296C", VA = "0x232296C", Slot = "7")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A3F4", Offset = "0x18A3F4")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}
