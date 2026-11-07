using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000089")]
	public class CustomDomainConfigType
	{
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		private string _certificateArn;

		[Token(Token = "0x17000109")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D6F0", Offset = "0x1D6F0")]
		public string CertificateArn
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x10F9EB4", Offset = "0x10F9EB4", VA = "0x10F9EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x10F9EBC", Offset = "0x10F9EBC", VA = "0x10F9EBC")]
			set
			{
			}
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x10F9EC4", Offset = "0x10F9EC4", VA = "0x10F9EC4")]
		internal bool IsSetCertificateArn()
		{
			return default;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x10F9ED4", Offset = "0x10F9ED4", VA = "0x10F9ED4")]
		public CustomDomainConfigType()
		{
		}
	}
}
