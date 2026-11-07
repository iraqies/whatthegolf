using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000030")]
	public class AdminConfirmSignUpRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000012")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x109C1D4", Offset = "0x109C1D4", VA = "0x109C1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x109C1DC", Offset = "0x109C1DC", VA = "0x109C1DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AE70", Offset = "0x1AE70")]
		public string Username
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x109C240", Offset = "0x109C240", VA = "0x109C240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x109C248", Offset = "0x109C248", VA = "0x109C248")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AEC0", Offset = "0x1AEC0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x109C260", Offset = "0x109C260", VA = "0x109C260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x109C268", Offset = "0x109C268", VA = "0x109C268")]
			set
			{
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x109C1E4", Offset = "0x109C1E4", VA = "0x109C1E4")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x109C250", Offset = "0x109C250", VA = "0x109C250")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x109C270", Offset = "0x109C270", VA = "0x109C270")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x109C280", Offset = "0x109C280", VA = "0x109C280")]
		public AdminConfirmSignUpRequest()
		{
		}
	}
}
