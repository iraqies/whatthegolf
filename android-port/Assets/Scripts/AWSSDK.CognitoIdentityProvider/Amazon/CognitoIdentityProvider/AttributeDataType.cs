using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000008")]
	public class AttributeDataType : ConstantClass
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AttributeDataType Boolean;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AttributeDataType DateTime;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AttributeDataType Number;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		public static readonly AttributeDataType String;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x10DE23C", Offset = "0x10DE23C", VA = "0x10DE23C")]
		public AttributeDataType(string value)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x10DE2C8", Offset = "0x10DE2C8", VA = "0x10DE2C8")]
		public static AttributeDataType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x10DE358", Offset = "0x10DE358", VA = "0x10DE358")]
		public static implicit operator AttributeDataType(string value)
		{
			return null;
		}
	}
}
