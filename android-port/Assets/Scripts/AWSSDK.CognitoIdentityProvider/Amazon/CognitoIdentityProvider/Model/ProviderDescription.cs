using System;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FB")]
	public class ProviderDescription
	{
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x10")]
		private DateTime? _creationDate;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x20")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x30")]
		private string _providerName;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x38")]
		private IdentityProviderTypeType _providerType;

		[Token(Token = "0x170001E3")]
		public DateTime CreationDate
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1141394", Offset = "0x1141394", VA = "0x1141394")]
			get
			{
				return default;
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x11413D4", Offset = "0x11413D4", VA = "0x11413D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1141488", Offset = "0x1141488", VA = "0x1141488")]
			get
			{
				return default;
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x11414C8", Offset = "0x11414C8", VA = "0x11414C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1FC18", Offset = "0x1FC18")]
		public string ProviderName
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x114157C", Offset = "0x114157C", VA = "0x114157C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1141584", Offset = "0x1141584", VA = "0x1141584")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public IdentityProviderTypeType ProviderType
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x114159C", Offset = "0x114159C", VA = "0x114159C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x11415A4", Offset = "0x11415A4", VA = "0x11415A4")]
			set
			{
			}
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1141448", Offset = "0x1141448", VA = "0x1141448")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x114153C", Offset = "0x114153C", VA = "0x114153C")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x114158C", Offset = "0x114158C", VA = "0x114158C")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x11415AC", Offset = "0x11415AC", VA = "0x11415AC")]
		internal bool IsSetProviderType()
		{
			return default;
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1141628", Offset = "0x1141628", VA = "0x1141628")]
		public ProviderDescription()
		{
		}
	}
}
