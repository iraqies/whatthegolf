using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000082")]
	public class CreateUserImportJobResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x28")]
		private UserImportJobType _userImportJob;

		[Token(Token = "0x170000DD")]
		public UserImportJobType UserImportJob
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x10F1458", Offset = "0x10F1458", VA = "0x10F1458")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x10F1460", Offset = "0x10F1460", VA = "0x10F1460")]
			set
			{
			}
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x10F1468", Offset = "0x10F1468", VA = "0x10F1468")]
		internal bool IsSetUserImportJob()
		{
			return default;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x10F1478", Offset = "0x10F1478", VA = "0x10F1478")]
		public CreateUserImportJobResponse()
		{
		}
	}
}
