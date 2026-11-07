using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011B")]
	public class StartUserImportJobRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x30")]
		private string _jobId;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700023F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x206DC", Offset = "0x206DC")]
		public string JobId
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1157300", Offset = "0x1157300", VA = "0x1157300")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1157308", Offset = "0x1157308", VA = "0x1157308")]
			set
			{
			}
		}

		[Token(Token = "0x17000240")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2072C", Offset = "0x2072C")]
		public string UserPoolId
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1157320", Offset = "0x1157320", VA = "0x1157320")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1157328", Offset = "0x1157328", VA = "0x1157328")]
			set
			{
			}
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1157310", Offset = "0x1157310", VA = "0x1157310")]
		internal bool IsSetJobId()
		{
			return default;
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x1157330", Offset = "0x1157330", VA = "0x1157330")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1157340", Offset = "0x1157340", VA = "0x1157340")]
		public StartUserImportJobRequest()
		{
		}
	}
}
