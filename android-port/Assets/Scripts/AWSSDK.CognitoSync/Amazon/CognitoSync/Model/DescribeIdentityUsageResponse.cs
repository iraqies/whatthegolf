using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000018")]
	public class DescribeIdentityUsageResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		private IdentityUsage _identityUsage;

		[Token(Token = "0x1700001D")]
		public IdentityUsage IdentityUsage
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1197E88", Offset = "0x1197E88", VA = "0x1197E88")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1197E90", Offset = "0x1197E90", VA = "0x1197E90")]
			set
			{
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1197E98", Offset = "0x1197E98", VA = "0x1197E98")]
		internal bool IsSetIdentityUsage()
		{
			return default;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1197EA8", Offset = "0x1197EA8", VA = "0x1197EA8")]
		public DescribeIdentityUsageResponse()
		{
		}
	}
}
