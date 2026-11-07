using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200006C")]
	public class ChangePasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x38")]
		private string _previousPassword;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x40")]
		private string _proposedPassword;

		[Token(Token = "0x170000A5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C708", Offset = "0x1C708")]
		public string AccessToken
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x10E1644", Offset = "0x10E1644", VA = "0x10E1644")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x10E164C", Offset = "0x10E164C", VA = "0x10E164C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C73C", Offset = "0x1C73C")]
		public string PreviousPassword
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x10E1664", Offset = "0x10E1664", VA = "0x10E1664")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x10E166C", Offset = "0x10E166C", VA = "0x10E166C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C78C", Offset = "0x1C78C")]
		public string ProposedPassword
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x10E1684", Offset = "0x10E1684", VA = "0x10E1684")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x10E168C", Offset = "0x10E168C", VA = "0x10E168C")]
			set
			{
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x10E1654", Offset = "0x10E1654", VA = "0x10E1654")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x10E1674", Offset = "0x10E1674", VA = "0x10E1674")]
		internal bool IsSetPreviousPassword()
		{
			return default;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x10E1694", Offset = "0x10E1694", VA = "0x10E1694")]
		internal bool IsSetProposedPassword()
		{
			return default;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x10E16A4", Offset = "0x10E16A4", VA = "0x10E16A4", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x10E16FC", Offset = "0x10E16FC", VA = "0x10E16FC")]
		public ChangePasswordRequest()
		{
		}
	}
}
