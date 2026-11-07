using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000016")]
	public class DescribeIdentityPoolUsageResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x28")]
		private IdentityPoolUsage _identityPoolUsage;

		[Token(Token = "0x1700001A")]
		public IdentityPoolUsage IdentityPoolUsage
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x11968D0", Offset = "0x11968D0", VA = "0x11968D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x11968D8", Offset = "0x11968D8", VA = "0x11968D8")]
			set
			{
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x11968E0", Offset = "0x11968E0", VA = "0x11968E0")]
		internal bool IsSetIdentityPoolUsage()
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x11968F0", Offset = "0x11968F0", VA = "0x11968F0")]
		public DescribeIdentityPoolUsageResponse()
		{
		}
	}
}
