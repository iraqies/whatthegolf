using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000088")]
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x22AE018", Offset = "0x22AE018", VA = "0x22AE018")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x22AE054", Offset = "0x22AE054", VA = "0x22AE054")]
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x22AE098", Offset = "0x22AE098", VA = "0x22AE098")]
		public CamelCaseNamingStrategy()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x22AE0A0", Offset = "0x22AE0A0", VA = "0x22AE0A0", Slot = "7")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18952C", Offset = "0x18952C")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}
