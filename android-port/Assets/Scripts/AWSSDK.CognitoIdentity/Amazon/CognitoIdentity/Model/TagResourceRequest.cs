using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200004B")]
	public class TagResourceRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _tags;

		[Token(Token = "0x17000086")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2390C", Offset = "0x2390C")]
		public string ResourceArn
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x11803A0", Offset = "0x11803A0", VA = "0x11803A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x11803A8", Offset = "0x11803A8", VA = "0x11803A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2395C", Offset = "0x2395C")]
		public Dictionary<string, string> Tags
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x11803C0", Offset = "0x11803C0", VA = "0x11803C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x11803C8", Offset = "0x11803C8", VA = "0x11803C8")]
			set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x11803B0", Offset = "0x11803B0", VA = "0x11803B0")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x11803D0", Offset = "0x11803D0", VA = "0x11803D0")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x118042C", Offset = "0x118042C", VA = "0x118042C")]
		public TagResourceRequest()
		{
		}
	}
}
