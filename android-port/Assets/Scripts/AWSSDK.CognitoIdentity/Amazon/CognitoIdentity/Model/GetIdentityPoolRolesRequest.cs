using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002B")]
	public class GetIdentityPoolRolesRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000049")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22B98", Offset = "0x22B98")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1087714", Offset = "0x1087714", VA = "0x1087714")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x108771C", Offset = "0x108771C", VA = "0x108771C")]
			set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1087724", Offset = "0x1087724", VA = "0x1087724")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1072E34", Offset = "0x1072E34", VA = "0x1072E34")]
		public GetIdentityPoolRolesRequest()
		{
		}
	}
}
