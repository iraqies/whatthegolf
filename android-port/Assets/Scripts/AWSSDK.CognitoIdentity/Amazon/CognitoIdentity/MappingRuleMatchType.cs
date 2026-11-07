using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000015")]
	public class MappingRuleMatchType : ConstantClass
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MappingRuleMatchType Contains;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly MappingRuleMatchType Equals;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly MappingRuleMatchType NotEqual;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		public static readonly MappingRuleMatchType StartsWith;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x109420C", Offset = "0x109420C", VA = "0x109420C")]
		public MappingRuleMatchType(string value)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1094298", Offset = "0x1094298", VA = "0x1094298")]
		public static MappingRuleMatchType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1094328", Offset = "0x1094328", VA = "0x1094328")]
		public static implicit operator MappingRuleMatchType(string value)
		{
			return null;
		}
	}
}
