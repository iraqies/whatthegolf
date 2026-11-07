using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000021")]
	public class DeleteIdentityPoolRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000033")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x227F4", Offset = "0x227F4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x107E71C", Offset = "0x107E71C", VA = "0x107E71C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x107E724", Offset = "0x107E724", VA = "0x107E724")]
			set
			{
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x107E72C", Offset = "0x107E72C", VA = "0x107E72C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x10719DC", Offset = "0x10719DC", VA = "0x10719DC")]
		public DeleteIdentityPoolRequest()
		{
		}
	}
}
