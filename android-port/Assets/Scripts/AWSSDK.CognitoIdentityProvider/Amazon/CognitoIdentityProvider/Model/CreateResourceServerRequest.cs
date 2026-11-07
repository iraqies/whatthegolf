using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007F")]
	public class CreateResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x30")]
		private string _identifier;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x38")]
		private string _name;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x40")]
		private List<ResourceServerScopeType> _scopes;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x170000D5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CFC4", Offset = "0x1CFC4")]
		public string Identifier
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x10EEEF8", Offset = "0x10EEEF8", VA = "0x10EEEF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x10EEF00", Offset = "0x10EEF00", VA = "0x10EEF00")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D014", Offset = "0x1D014")]
		public string Name
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x10EEF18", Offset = "0x10EEF18", VA = "0x10EEF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x10EEF20", Offset = "0x10EEF20", VA = "0x10EEF20")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D064", Offset = "0x1D064")]
		public List<ResourceServerScopeType> Scopes
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x10EEF38", Offset = "0x10EEF38", VA = "0x10EEF38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x10EEF40", Offset = "0x10EEF40", VA = "0x10EEF40")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D09C", Offset = "0x1D09C")]
		public string UserPoolId
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x10EEFA0", Offset = "0x10EEFA0", VA = "0x10EEFA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x10EEFA8", Offset = "0x10EEFA8", VA = "0x10EEFA8")]
			set
			{
			}
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x10EEF08", Offset = "0x10EEF08", VA = "0x10EEF08")]
		internal bool IsSetIdentifier()
		{
			return default;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x10EEF28", Offset = "0x10EEF28", VA = "0x10EEF28")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x10EEF48", Offset = "0x10EEF48", VA = "0x10EEF48")]
		internal bool IsSetScopes()
		{
			return default;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x10EEFB0", Offset = "0x10EEFB0", VA = "0x10EEFB0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x10EEFC0", Offset = "0x10EEFC0", VA = "0x10EEFC0")]
		public CreateResourceServerRequest()
		{
		}
	}
}
