using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000023")]
	public class DescribeIdentityPoolRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000034")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22844", Offset = "0x22844")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x107FB14", Offset = "0x107FB14", VA = "0x107FB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x107FB1C", Offset = "0x107FB1C", VA = "0x107FB1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x107FB24", Offset = "0x107FB24", VA = "0x107FB24")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1072184", Offset = "0x1072184", VA = "0x1072184")]
		public DescribeIdentityPoolRequest()
		{
		}
	}
}
