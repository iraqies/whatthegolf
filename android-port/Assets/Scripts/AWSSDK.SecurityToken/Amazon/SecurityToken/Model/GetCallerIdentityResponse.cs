using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000024")]
	public class GetCallerIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x28")]
		private string _account;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x30")]
		private string _arn;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x38")]
		private string _userId;

		[Token(Token = "0x17000041")]
		public string Account
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x12DFCA8", Offset = "0x12DFCA8", VA = "0x12DFCA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x12DFCB0", Offset = "0x12DFCB0", VA = "0x12DFCB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3150C", Offset = "0x3150C")]
		public string Arn
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x12DFCC8", Offset = "0x12DFCC8", VA = "0x12DFCC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x12DFCD0", Offset = "0x12DFCD0", VA = "0x12DFCD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public string UserId
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x12DFCE8", Offset = "0x12DFCE8", VA = "0x12DFCE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x12DFCF0", Offset = "0x12DFCF0", VA = "0x12DFCF0")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x12DFCB8", Offset = "0x12DFCB8", VA = "0x12DFCB8")]
		internal bool IsSetAccount()
		{
			return default;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x12DFCD8", Offset = "0x12DFCD8", VA = "0x12DFCD8")]
		internal bool IsSetArn()
		{
			return default;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x12DFCF8", Offset = "0x12DFCF8", VA = "0x12DFCF8")]
		internal bool IsSetUserId()
		{
			return default;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x12DFD08", Offset = "0x12DFD08", VA = "0x12DFD08")]
		public GetCallerIdentityResponse()
		{
		}
	}
}
