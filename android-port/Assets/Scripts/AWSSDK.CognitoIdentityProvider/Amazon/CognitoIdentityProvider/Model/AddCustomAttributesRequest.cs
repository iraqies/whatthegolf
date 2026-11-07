using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200002C")]
	public class AddCustomAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x30")]
		private List<SchemaAttributeType> _customAttributes;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700000D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1ACE0", Offset = "0x1ACE0")]
		public List<SchemaAttributeType> CustomAttributes
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x1099578", Offset = "0x1099578", VA = "0x1099578")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1099580", Offset = "0x1099580", VA = "0x1099580")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AD30", Offset = "0x1AD30")]
		public string UserPoolId
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x10995E0", Offset = "0x10995E0", VA = "0x10995E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x10995E8", Offset = "0x10995E8", VA = "0x10995E8")]
			set
			{
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1099588", Offset = "0x1099588", VA = "0x1099588")]
		internal bool IsSetCustomAttributes()
		{
			return default;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x10995F0", Offset = "0x10995F0", VA = "0x10995F0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1099600", Offset = "0x1099600", VA = "0x1099600")]
		public AddCustomAttributesRequest()
		{
		}
	}
}
