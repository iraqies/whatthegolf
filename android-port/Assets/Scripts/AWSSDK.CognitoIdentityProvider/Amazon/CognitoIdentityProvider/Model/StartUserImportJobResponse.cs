using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011C")]
	public class StartUserImportJobResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x28")]
		private UserImportJobType _userImportJob;

		[Token(Token = "0x17000241")]
		public UserImportJobType UserImportJob
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1157E1C", Offset = "0x1157E1C", VA = "0x1157E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1157E24", Offset = "0x1157E24", VA = "0x1157E24")]
			set
			{
			}
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x1157E2C", Offset = "0x1157E2C", VA = "0x1157E2C")]
		internal bool IsSetUserImportJob()
		{
			return default;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1157E3C", Offset = "0x1157E3C", VA = "0x1157E3C")]
		public StartUserImportJobResponse()
		{
		}
	}
}
