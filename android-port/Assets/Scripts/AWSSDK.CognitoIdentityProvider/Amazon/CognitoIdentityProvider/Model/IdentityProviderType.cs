using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000CE")]
	public class IdentityProviderType
	{
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> _attributeMapping;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x18")]
		private DateTime? _creationDate;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _idpIdentifiers;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _providerDetails;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x48")]
		private string _providerName;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x50")]
		private IdentityProviderTypeType _providerType;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x58")]
		private string _userPoolId;

		[Token(Token = "0x1700017E")]
		public Dictionary<string, string> AttributeMapping
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1127C44", Offset = "0x1127C44", VA = "0x1127C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1127C4C", Offset = "0x1127C4C", VA = "0x1127C4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1127CB0", Offset = "0x1127CB0", VA = "0x1127CB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1127CF0", Offset = "0x1127CF0", VA = "0x1127CF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1E9EC", Offset = "0x1E9EC")]
		public List<string> IdpIdentifiers
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1127DA4", Offset = "0x1127DA4", VA = "0x1127DA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1127DAC", Offset = "0x1127DAC", VA = "0x1127DAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1127E0C", Offset = "0x1127E0C", VA = "0x1127E0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1127E4C", Offset = "0x1127E4C", VA = "0x1127E4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public Dictionary<string, string> ProviderDetails
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1127F00", Offset = "0x1127F00", VA = "0x1127F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1127F08", Offset = "0x1127F08", VA = "0x1127F08")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1EA34", Offset = "0x1EA34")]
		public string ProviderName
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1127F6C", Offset = "0x1127F6C", VA = "0x1127F6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1127F74", Offset = "0x1127F74", VA = "0x1127F74")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public IdentityProviderTypeType ProviderType
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1127F8C", Offset = "0x1127F8C", VA = "0x1127F8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1127F94", Offset = "0x1127F94", VA = "0x1127F94")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1EA7C", Offset = "0x1EA7C")]
		public string UserPoolId
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1128018", Offset = "0x1128018", VA = "0x1128018")]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1128020", Offset = "0x1128020", VA = "0x1128020")]
			set
			{
			}
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1127C54", Offset = "0x1127C54", VA = "0x1127C54")]
		internal bool IsSetAttributeMapping()
		{
			return default;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1127D64", Offset = "0x1127D64", VA = "0x1127D64")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1127DB4", Offset = "0x1127DB4", VA = "0x1127DB4")]
		internal bool IsSetIdpIdentifiers()
		{
			return default;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1127EC0", Offset = "0x1127EC0", VA = "0x1127EC0")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1127F10", Offset = "0x1127F10", VA = "0x1127F10")]
		internal bool IsSetProviderDetails()
		{
			return default;
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1127F7C", Offset = "0x1127F7C", VA = "0x1127F7C")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1127F9C", Offset = "0x1127F9C", VA = "0x1127F9C")]
		internal bool IsSetProviderType()
		{
			return default;
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1128028", Offset = "0x1128028", VA = "0x1128028")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1128038", Offset = "0x1128038", VA = "0x1128038")]
		public IdentityProviderType()
		{
		}
	}
}
