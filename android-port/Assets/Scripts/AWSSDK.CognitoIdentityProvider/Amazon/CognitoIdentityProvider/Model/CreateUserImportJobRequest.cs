using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000081")]
	public class CreateUserImportJobRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x30")]
		private string _cloudWatchLogsRoleArn;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x38")]
		private string _jobName;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170000DA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D120", Offset = "0x1D120")]
		public string CloudWatchLogsRoleArn
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x10F08B0", Offset = "0x10F08B0", VA = "0x10F08B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x10F08B8", Offset = "0x10F08B8", VA = "0x10F08B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D170", Offset = "0x1D170")]
		public string JobName
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x10F08D0", Offset = "0x10F08D0", VA = "0x10F08D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x10F08D8", Offset = "0x10F08D8", VA = "0x10F08D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D1C0", Offset = "0x1D1C0")]
		public string UserPoolId
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x10F08F0", Offset = "0x10F08F0", VA = "0x10F08F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x10F08F8", Offset = "0x10F08F8", VA = "0x10F08F8")]
			set
			{
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x10F08C0", Offset = "0x10F08C0", VA = "0x10F08C0")]
		internal bool IsSetCloudWatchLogsRoleArn()
		{
			return default;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x10F08E0", Offset = "0x10F08E0", VA = "0x10F08E0")]
		internal bool IsSetJobName()
		{
			return default;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x10F0900", Offset = "0x10F0900", VA = "0x10F0900")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x10F0910", Offset = "0x10F0910", VA = "0x10F0910")]
		public CreateUserImportJobRequest()
		{
		}
	}
}
