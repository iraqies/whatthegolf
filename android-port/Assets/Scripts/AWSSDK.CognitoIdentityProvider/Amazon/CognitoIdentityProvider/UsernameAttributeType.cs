using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000021")]
	public class UsernameAttributeType : ConstantClass
	{
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UsernameAttributeType Email;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UsernameAttributeType Phone_number;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1179480", Offset = "0x1179480", VA = "0x1179480")]
		public UsernameAttributeType(string value)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x117950C", Offset = "0x117950C", VA = "0x117950C")]
		public static UsernameAttributeType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x117959C", Offset = "0x117959C", VA = "0x117959C")]
		public static implicit operator UsernameAttributeType(string value)
		{
			return null;
		}
	}
}
