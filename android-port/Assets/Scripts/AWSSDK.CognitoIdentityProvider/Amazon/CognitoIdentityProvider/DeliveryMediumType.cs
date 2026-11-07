using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000F")]
	public class DeliveryMediumType : ConstantClass
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DeliveryMediumType EMAIL;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DeliveryMediumType SMS;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1104A40", Offset = "0x1104A40", VA = "0x1104A40")]
		public DeliveryMediumType(string value)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1104ACC", Offset = "0x1104ACC", VA = "0x1104ACC")]
		public static DeliveryMediumType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1104B5C", Offset = "0x1104B5C", VA = "0x1104B5C")]
		public static implicit operator DeliveryMediumType(string value)
		{
			return null;
		}
	}
}
