using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000017")]
	public class DescribeIdentityUsageRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x1700001B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24654", Offset = "0x24654")]
		public string IdentityId
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x119772C", Offset = "0x119772C", VA = "0x119772C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1197734", Offset = "0x1197734", VA = "0x1197734")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x246A4", Offset = "0x246A4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x119774C", Offset = "0x119774C", VA = "0x119774C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1197754", Offset = "0x1197754", VA = "0x1197754")]
			set
			{
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x119773C", Offset = "0x119773C", VA = "0x119773C")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x119775C", Offset = "0x119775C", VA = "0x119775C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x119776C", Offset = "0x119776C", VA = "0x119776C")]
		public DescribeIdentityUsageRequest()
		{
		}
	}
}
