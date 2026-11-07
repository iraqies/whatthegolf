using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000053")]
	public class UntagResourceRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _tagKeys;

		[Token(Token = "0x17000091")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23BDC", Offset = "0x23BDC")]
		public string ResourceArn
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1184FB4", Offset = "0x1184FB4", VA = "0x1184FB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1184FBC", Offset = "0x1184FBC", VA = "0x1184FBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23C2C", Offset = "0x23C2C")]
		public List<string> TagKeys
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1184FD4", Offset = "0x1184FD4", VA = "0x1184FD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1184FDC", Offset = "0x1184FDC", VA = "0x1184FDC")]
			set
			{
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1184FC4", Offset = "0x1184FC4", VA = "0x1184FC4")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1184FE4", Offset = "0x1184FE4", VA = "0x1184FE4")]
		internal bool IsSetTagKeys()
		{
			return default;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x118503C", Offset = "0x118503C", VA = "0x118503C")]
		public UntagResourceRequest()
		{
		}
	}
}
