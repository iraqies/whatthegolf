using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200006B")]
	public class ChallengeResponseType
	{
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x10")]
		private ChallengeName _challengeName;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		private ChallengeResponse _challengeResponse;

		[Token(Token = "0x170000A3")]
		public ChallengeName ChallengeName
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x10E1140", Offset = "0x10E1140", VA = "0x10E1140")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x10E1148", Offset = "0x10E1148", VA = "0x10E1148")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public ChallengeResponse ChallengeResponse
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x10E11CC", Offset = "0x10E11CC", VA = "0x10E11CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x10E11D4", Offset = "0x10E11D4", VA = "0x10E11D4")]
			set
			{
			}
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x10E1150", Offset = "0x10E1150", VA = "0x10E1150")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x10E11DC", Offset = "0x10E11DC", VA = "0x10E11DC")]
		internal bool IsSetChallengeResponse()
		{
			return default;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x10E1258", Offset = "0x10E1258", VA = "0x10E1258")]
		public ChallengeResponseType()
		{
		}
	}
}
