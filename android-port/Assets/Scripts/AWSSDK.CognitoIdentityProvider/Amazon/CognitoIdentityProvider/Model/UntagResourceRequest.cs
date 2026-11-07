using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000128")]
	public class UntagResourceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _tagKeys;

		[Token(Token = "0x17000250")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20930", Offset = "0x20930")]
		public string ResourceArn
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x115DCA0", Offset = "0x115DCA0", VA = "0x115DCA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x115DCA8", Offset = "0x115DCA8", VA = "0x115DCA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000251")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20980", Offset = "0x20980")]
		public List<string> TagKeys
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x115DCC0", Offset = "0x115DCC0", VA = "0x115DCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x115DCC8", Offset = "0x115DCC8", VA = "0x115DCC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x115DCB0", Offset = "0x115DCB0", VA = "0x115DCB0")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x115DCD0", Offset = "0x115DCD0", VA = "0x115DCD0")]
		internal bool IsSetTagKeys()
		{
			return default;
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x115DD28", Offset = "0x115DD28", VA = "0x115DD28")]
		public UntagResourceRequest()
		{
		}
	}
}
