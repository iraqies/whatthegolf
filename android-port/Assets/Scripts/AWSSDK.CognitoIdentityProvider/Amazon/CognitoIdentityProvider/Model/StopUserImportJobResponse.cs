using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011E")]
	public class StopUserImportJobResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x28")]
		private UserImportJobType _userImportJob;

		[Token(Token = "0x17000244")]
		public UserImportJobType UserImportJob
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1159704", Offset = "0x1159704", VA = "0x1159704")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x115970C", Offset = "0x115970C", VA = "0x115970C")]
			set
			{
			}
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1159714", Offset = "0x1159714", VA = "0x1159714")]
		internal bool IsSetUserImportJob()
		{
			return default;
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1159724", Offset = "0x1159724", VA = "0x1159724")]
		public StopUserImportJobResponse()
		{
		}
	}
}
