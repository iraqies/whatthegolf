using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000012")]
	public class DeleteDatasetResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		private Dataset _dataset;

		[Token(Token = "0x17000014")]
		public Dataset Dataset
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x11943E0", Offset = "0x11943E0", VA = "0x11943E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x11943E8", Offset = "0x11943E8", VA = "0x11943E8")]
			set
			{
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x11943F0", Offset = "0x11943F0", VA = "0x11943F0")]
		internal bool IsSetDataset()
		{
			return default;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1194400", Offset = "0x1194400", VA = "0x1194400")]
		public DeleteDatasetResponse()
		{
		}
	}
}
