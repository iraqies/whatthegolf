using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A1")]
	public class DescribeUserImportJobResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x28")]
		private UserImportJobType _userImportJob;

		[Token(Token = "0x17000123")]
		public UserImportJobType UserImportJob
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x1109868", Offset = "0x1109868", VA = "0x1109868")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1109870", Offset = "0x1109870", VA = "0x1109870")]
			set
			{
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1109878", Offset = "0x1109878", VA = "0x1109878")]
		internal bool IsSetUserImportJob()
		{
			return default;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1109888", Offset = "0x1109888", VA = "0x1109888")]
		public DescribeUserImportJobResponse()
		{
		}
	}
}
