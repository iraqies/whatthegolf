using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014F")]
	public class VerifySoftwareTokenResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		private string _session;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x30")]
		private VerifySoftwareTokenResponseType _status;

		[Token(Token = "0x170002F2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22034", Offset = "0x22034")]
		public string Session
		{
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x117B6C4", Offset = "0x117B6C4", VA = "0x117B6C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C5E")]
			[Address(RVA = "0x117B6CC", Offset = "0x117B6CC", VA = "0x117B6CC")]
			set
			{
			}
		}

		[Token(Token = "0x170002F3")]
		public VerifySoftwareTokenResponseType Status
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x117B6E4", Offset = "0x117B6E4", VA = "0x117B6E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x117B6EC", Offset = "0x117B6EC", VA = "0x117B6EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x117B6D4", Offset = "0x117B6D4", VA = "0x117B6D4")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x117B6F4", Offset = "0x117B6F4", VA = "0x117B6F4")]
		internal bool IsSetStatus()
		{
			return default;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x117B770", Offset = "0x117B770", VA = "0x117B770")]
		public VerifySoftwareTokenResponse()
		{
		}
	}
}
