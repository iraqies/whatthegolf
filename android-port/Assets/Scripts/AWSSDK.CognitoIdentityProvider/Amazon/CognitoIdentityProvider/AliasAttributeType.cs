using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000007")]
	public class AliasAttributeType : ConstantClass
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AliasAttributeType Email;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AliasAttributeType Phone_number;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AliasAttributeType Preferred_username;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x10C71E0", Offset = "0x10C71E0", VA = "0x10C71E0")]
		public AliasAttributeType(string value)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x10C726C", Offset = "0x10C726C", VA = "0x10C726C")]
		public static AliasAttributeType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x10C72FC", Offset = "0x10C72FC", VA = "0x10C72FC")]
		public static implicit operator AliasAttributeType(string value)
		{
			return null;
		}
	}
}
