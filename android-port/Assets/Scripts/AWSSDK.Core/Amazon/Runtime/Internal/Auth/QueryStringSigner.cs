using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x2000252")]
	public class QueryStringSigner : AbstractAWSSigner
	{
		[Token(Token = "0x4000873")]
		private const string SignatureVersion2 = "2";

		[Token(Token = "0x1700045F")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x600119E")]
			[Address(RVA = "0x12533CC", Offset = "0x12533CC", VA = "0x12533CC", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600119D")]
		[Address(RVA = "0x12533C4", Offset = "0x12533C4", VA = "0x12533C4")]
		public QueryStringSigner()
		{
		}

		[Token(Token = "0x600119F")]
		[Address(RVA = "0x12533D4", Offset = "0x12533D4", VA = "0x12533D4", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}
	}
}
