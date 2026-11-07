using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000014")]
	public class DescribeDatasetResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		private Dataset _dataset;

		[Token(Token = "0x17000018")]
		public Dataset Dataset
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x11958A8", Offset = "0x11958A8", VA = "0x11958A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x11958B0", Offset = "0x11958B0", VA = "0x11958B0")]
			set
			{
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x11958B8", Offset = "0x11958B8", VA = "0x11958B8")]
		internal bool IsSetDataset()
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x11958C8", Offset = "0x11958C8", VA = "0x11958C8")]
		public DescribeDatasetResponse()
		{
		}
	}
}
