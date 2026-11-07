using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000025")]
	public class DescribeIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x1700003F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x229E8", Offset = "0x229E8")]
		public string IdentityId
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1081EB4", Offset = "0x1081EB4", VA = "0x1081EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1081EBC", Offset = "0x1081EBC", VA = "0x1081EBC")]
			set
			{
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1081EC4", Offset = "0x1081EC4", VA = "0x1081EC4")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1071DB0", Offset = "0x1071DB0", VA = "0x1071DB0")]
		public DescribeIdentityRequest()
		{
		}
	}
}
