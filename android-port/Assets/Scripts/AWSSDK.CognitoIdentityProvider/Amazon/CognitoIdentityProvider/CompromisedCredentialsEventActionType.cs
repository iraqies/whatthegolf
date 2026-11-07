using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000D")]
	public class CompromisedCredentialsEventActionType : ConstantClass
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CompromisedCredentialsEventActionType BLOCK;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		public static readonly CompromisedCredentialsEventActionType NO_ACTION;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x10E3EE4", Offset = "0x10E3EE4", VA = "0x10E3EE4")]
		public CompromisedCredentialsEventActionType(string value)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10E3F70", Offset = "0x10E3F70", VA = "0x10E3F70")]
		public static CompromisedCredentialsEventActionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x10E3D58", Offset = "0x10E3D58", VA = "0x10E3D58")]
		public static implicit operator CompromisedCredentialsEventActionType(string value)
		{
			return null;
		}
	}
}
