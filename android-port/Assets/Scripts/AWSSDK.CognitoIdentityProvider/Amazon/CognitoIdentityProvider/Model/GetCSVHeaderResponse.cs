using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B8")]
	public class GetCSVHeaderResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _csvHeader;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x17000156")]
		public List<string> CSVHeader
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x11184C4", Offset = "0x11184C4", VA = "0x11184C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x11184CC", Offset = "0x11184CC", VA = "0x11184CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E388", Offset = "0x1E388")]
		public string UserPoolId
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x111852C", Offset = "0x111852C", VA = "0x111852C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1118534", Offset = "0x1118534", VA = "0x1118534")]
			set
			{
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x11184D4", Offset = "0x11184D4", VA = "0x11184D4")]
		internal bool IsSetCSVHeader()
		{
			return default;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x111853C", Offset = "0x111853C", VA = "0x111853C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x111854C", Offset = "0x111854C", VA = "0x111854C")]
		public GetCSVHeaderResponse()
		{
		}
	}
}
