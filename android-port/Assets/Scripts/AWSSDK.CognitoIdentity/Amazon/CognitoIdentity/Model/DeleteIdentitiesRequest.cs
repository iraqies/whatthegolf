using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001F")]
	public class DeleteIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _identityIdsToDelete;

		[Token(Token = "0x17000031")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2276C", Offset = "0x2276C")]
		public List<string> IdentityIdsToDelete
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x107D080", Offset = "0x107D080", VA = "0x107D080")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x107D088", Offset = "0x107D088", VA = "0x107D088")]
			set
			{
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x107D090", Offset = "0x107D090", VA = "0x107D090")]
		internal bool IsSetIdentityIdsToDelete()
		{
			return default;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x107D0E8", Offset = "0x107D0E8", VA = "0x107D0E8")]
		public DeleteIdentitiesRequest()
		{
		}
	}
}
