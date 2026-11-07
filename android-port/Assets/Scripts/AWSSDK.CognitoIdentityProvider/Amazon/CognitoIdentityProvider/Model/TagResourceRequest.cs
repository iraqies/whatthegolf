using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000120")]
	public class TagResourceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _tags;

		[Token(Token = "0x17000247")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2081C", Offset = "0x2081C")]
		public string ResourceArn
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x115B260", Offset = "0x115B260", VA = "0x115B260")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x115B268", Offset = "0x115B268", VA = "0x115B268")]
			set
			{
			}
		}

		[Token(Token = "0x17000248")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2086C", Offset = "0x2086C")]
		public Dictionary<string, string> Tags
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x115B280", Offset = "0x115B280", VA = "0x115B280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x115B288", Offset = "0x115B288", VA = "0x115B288")]
			set
			{
			}
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x115B270", Offset = "0x115B270", VA = "0x115B270")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x115B290", Offset = "0x115B290", VA = "0x115B290")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x115B2EC", Offset = "0x115B2EC", VA = "0x115B2EC")]
		public TagResourceRequest()
		{
		}
	}
}
