using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011D")]
	public class StopUserImportJobRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x30")]
		private string _jobId;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000242")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2077C", Offset = "0x2077C")]
		public string JobId
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1158BE8", Offset = "0x1158BE8", VA = "0x1158BE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1158BF0", Offset = "0x1158BF0", VA = "0x1158BF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000243")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x207CC", Offset = "0x207CC")]
		public string UserPoolId
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1158C08", Offset = "0x1158C08", VA = "0x1158C08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1158C10", Offset = "0x1158C10", VA = "0x1158C10")]
			set
			{
			}
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1158BF8", Offset = "0x1158BF8", VA = "0x1158BF8")]
		internal bool IsSetJobId()
		{
			return default;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1158C18", Offset = "0x1158C18", VA = "0x1158C18")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1158C28", Offset = "0x1158C28", VA = "0x1158C28")]
		public StopUserImportJobRequest()
		{
		}
	}
}
