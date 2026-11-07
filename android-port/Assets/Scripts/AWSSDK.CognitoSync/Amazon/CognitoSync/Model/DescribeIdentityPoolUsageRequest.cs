using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000015")]
	public class DescribeIdentityPoolUsageRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000019")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24604", Offset = "0x24604")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1196280", Offset = "0x1196280", VA = "0x1196280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1196288", Offset = "0x1196288", VA = "0x1196288")]
			set
			{
			}
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1196290", Offset = "0x1196290", VA = "0x1196290")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x118D900", Offset = "0x118D900", VA = "0x118D900")]
		public DescribeIdentityPoolUsageRequest()
		{
		}
	}
}
