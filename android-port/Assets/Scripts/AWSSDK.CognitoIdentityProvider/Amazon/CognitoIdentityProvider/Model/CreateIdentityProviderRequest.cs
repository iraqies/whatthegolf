using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007D")]
	public class CreateIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _attributeMapping;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _idpIdentifiers;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _providerDetails;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x48")]
		private string _providerName;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x50")]
		private IdentityProviderTypeType _providerType;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x58")]
		private string _userPoolId;

		[Token(Token = "0x170000CE")]
		public Dictionary<string, string> AttributeMapping
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x10ECDC0", Offset = "0x10ECDC0", VA = "0x10ECDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x10ECDC8", Offset = "0x10ECDC8", VA = "0x10ECDC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CE40", Offset = "0x1CE40")]
		public List<string> IdpIdentifiers
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x10ECE2C", Offset = "0x10ECE2C", VA = "0x10ECE2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x10ECE34", Offset = "0x10ECE34", VA = "0x10ECE34")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CE88", Offset = "0x1CE88")]
		public Dictionary<string, string> ProviderDetails
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x10ECE94", Offset = "0x10ECE94", VA = "0x10ECE94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x10ECE9C", Offset = "0x10ECE9C", VA = "0x10ECE9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CEBC", Offset = "0x1CEBC")]
		public string ProviderName
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x10ECF00", Offset = "0x10ECF00", VA = "0x10ECF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x10ECF08", Offset = "0x10ECF08", VA = "0x10ECF08")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CF0C", Offset = "0x1CF0C")]
		public IdentityProviderTypeType ProviderType
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x10ECF20", Offset = "0x10ECF20", VA = "0x10ECF20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x10ECF28", Offset = "0x10ECF28", VA = "0x10ECF28")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CF40", Offset = "0x1CF40")]
		public string UserPoolId
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x10ECFAC", Offset = "0x10ECFAC", VA = "0x10ECFAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x10ECFB4", Offset = "0x10ECFB4", VA = "0x10ECFB4")]
			set
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x10ECDD0", Offset = "0x10ECDD0", VA = "0x10ECDD0")]
		internal bool IsSetAttributeMapping()
		{
			return default;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10ECE3C", Offset = "0x10ECE3C", VA = "0x10ECE3C")]
		internal bool IsSetIdpIdentifiers()
		{
			return default;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x10ECEA4", Offset = "0x10ECEA4", VA = "0x10ECEA4")]
		internal bool IsSetProviderDetails()
		{
			return default;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x10ECF10", Offset = "0x10ECF10", VA = "0x10ECF10")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x10ECF30", Offset = "0x10ECF30", VA = "0x10ECF30")]
		internal bool IsSetProviderType()
		{
			return default;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x10ECFBC", Offset = "0x10ECFBC", VA = "0x10ECFBC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x10ECFCC", Offset = "0x10ECFCC", VA = "0x10ECFCC")]
		public CreateIdentityProviderRequest()
		{
		}
	}
}
