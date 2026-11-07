using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001B")]
	public class PreventUserExistenceErrorTypes : ConstantClass
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PreventUserExistenceErrorTypes ENABLED;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x8")]
		public static readonly PreventUserExistenceErrorTypes LEGACY;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1141078", Offset = "0x1141078", VA = "0x1141078")]
		public PreventUserExistenceErrorTypes(string value)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1141104", Offset = "0x1141104", VA = "0x1141104")]
		public static PreventUserExistenceErrorTypes FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1141194", Offset = "0x1141194", VA = "0x1141194")]
		public static implicit operator PreventUserExistenceErrorTypes(string value)
		{
			return null;
		}
	}
}
