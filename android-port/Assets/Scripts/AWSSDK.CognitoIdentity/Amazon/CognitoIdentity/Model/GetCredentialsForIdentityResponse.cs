using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002A")]
	public class GetCredentialsForIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x28")]
		private Credentials _credentials;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x17000047")]
		public Credentials Credentials
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1084F20", Offset = "0x1084F20", VA = "0x1084F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1084F28", Offset = "0x1084F28", VA = "0x1084F28")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22B50", Offset = "0x22B50")]
		public string IdentityId
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1084F40", Offset = "0x1084F40", VA = "0x1084F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1084F48", Offset = "0x1084F48", VA = "0x1084F48")]
			set
			{
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1084F30", Offset = "0x1084F30", VA = "0x1084F30")]
		internal bool IsSetCredentials()
		{
			return default;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1084F50", Offset = "0x1084F50", VA = "0x1084F50")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1084F60", Offset = "0x1084F60", VA = "0x1084F60")]
		public GetCredentialsForIdentityResponse()
		{
		}
	}
}
