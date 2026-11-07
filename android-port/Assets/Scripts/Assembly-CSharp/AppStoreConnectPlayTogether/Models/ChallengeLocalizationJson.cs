using Il2CppDummyDll;

namespace AppStoreConnectPlayTogether.Models
{
	[Token(Token = "0x2001481")]
	public class ChallengeLocalizationJson
	{
		[Token(Token = "0x4007142")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE1C", Offset = "0x5CE1C")]
		private string locale__BackingField;

		[Token(Token = "0x4007143")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE2C", Offset = "0x5CE2C")]
		private string name__BackingField;

		[Token(Token = "0x4007144")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CE3C", Offset = "0x5CE3C")]
		private string details__BackingField;

		[Token(Token = "0x17000B00")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73BC4", Offset = "0x73BC4")]
		public string locale
		{
			[Token(Token = "0x6006089")]
			[Address(RVA = "0x1894C38", Offset = "0x1894C38", VA = "0x1894C38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73044", Offset = "0x73044")]
			set
			{
			}
		}

		[Token(Token = "0x17000B01")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73BFC", Offset = "0x73BFC")]
		public string name
		{
			[Token(Token = "0x600608A")]
			[Address(RVA = "0x1894C40", Offset = "0x1894C40", VA = "0x1894C40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73054", Offset = "0x73054")]
			set
			{
			}
		}

		[Token(Token = "0x17000B02")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73C34", Offset = "0x73C34")]
		public string details
		{
			[Token(Token = "0x600608B")]
			[Address(RVA = "0x1894C48", Offset = "0x1894C48", VA = "0x1894C48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x73064", Offset = "0x73064")]
			set
			{
			}
		}

		[Token(Token = "0x6006088")]
		[Address(RVA = "0x1894BF8", Offset = "0x1894BF8", VA = "0x1894BF8")]
		public ChallengeLocalizationJson(string locale, string name, string details)
		{
		}
	}
}
