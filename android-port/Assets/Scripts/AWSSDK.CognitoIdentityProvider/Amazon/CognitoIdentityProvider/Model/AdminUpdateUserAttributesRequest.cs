using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200005F")]
	public class AdminUpdateUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000084")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x10C3798", Offset = "0x10C3798", VA = "0x10C3798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x10C37A0", Offset = "0x10C37A0", VA = "0x10C37A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C38C", Offset = "0x1C38C")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x10C3804", Offset = "0x10C3804", VA = "0x10C3804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x10C380C", Offset = "0x10C380C", VA = "0x10C380C")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C3C0", Offset = "0x1C3C0")]
		public string Username
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x10C386C", Offset = "0x10C386C", VA = "0x10C386C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x10C3874", Offset = "0x10C3874", VA = "0x10C3874")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C410", Offset = "0x1C410")]
		public string UserPoolId
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x10C388C", Offset = "0x10C388C", VA = "0x10C388C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x10C3894", Offset = "0x10C3894", VA = "0x10C3894")]
			set
			{
			}
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x10C37A8", Offset = "0x10C37A8", VA = "0x10C37A8")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x10C3814", Offset = "0x10C3814", VA = "0x10C3814")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10C387C", Offset = "0x10C387C", VA = "0x10C387C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x10C389C", Offset = "0x10C389C", VA = "0x10C389C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x10C38AC", Offset = "0x10C38AC", VA = "0x10C38AC")]
		public AdminUpdateUserAttributesRequest()
		{
		}
	}
}
