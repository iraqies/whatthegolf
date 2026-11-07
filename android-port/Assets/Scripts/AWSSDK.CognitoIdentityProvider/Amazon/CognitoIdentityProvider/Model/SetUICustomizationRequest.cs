using System.IO;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200010B")]
	public class SetUICustomizationRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x30")]
		private string _clientId;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x38")]
		private string _css;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x40")]
		private MemoryStream _imageFile;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000219")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x202EC", Offset = "0x202EC")]
		public string ClientId
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x114D19C", Offset = "0x114D19C", VA = "0x114D19C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x114D1A4", Offset = "0x114D1A4", VA = "0x114D1A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public string CSS
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x114D1BC", Offset = "0x114D1BC", VA = "0x114D1BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x114D1C4", Offset = "0x114D1C4", VA = "0x114D1C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public MemoryStream ImageFile
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x114D1DC", Offset = "0x114D1DC", VA = "0x114D1DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x114D1E4", Offset = "0x114D1E4", VA = "0x114D1E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20334", Offset = "0x20334")]
		public string UserPoolId
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x114D1FC", Offset = "0x114D1FC", VA = "0x114D1FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x114D204", Offset = "0x114D204", VA = "0x114D204")]
			set
			{
			}
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x114D1AC", Offset = "0x114D1AC", VA = "0x114D1AC")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x114D1CC", Offset = "0x114D1CC", VA = "0x114D1CC")]
		internal bool IsSetCSS()
		{
			return default;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x114D1EC", Offset = "0x114D1EC", VA = "0x114D1EC")]
		internal bool IsSetImageFile()
		{
			return default;
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x114D20C", Offset = "0x114D20C", VA = "0x114D20C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x114D21C", Offset = "0x114D21C", VA = "0x114D21C")]
		public SetUICustomizationRequest()
		{
		}
	}
}
