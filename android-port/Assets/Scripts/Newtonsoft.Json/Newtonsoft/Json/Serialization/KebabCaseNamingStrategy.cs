using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C0")]
	public class KebabCaseNamingStrategy : NamingStrategy
	{
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2319FDC", Offset = "0x2319FDC", VA = "0x2319FDC")]
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x231A020", Offset = "0x231A020", VA = "0x231A020")]
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x231A064", Offset = "0x231A064", VA = "0x231A064")]
		public KebabCaseNamingStrategy()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x231A06C", Offset = "0x231A06C", VA = "0x231A06C", Slot = "7")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A358", Offset = "0x18A358")]
		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}
