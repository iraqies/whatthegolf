using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000046")]
	public class AdminInitiateAuthResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x28")]
		private AuthenticationResultType _authenticationResult;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x30")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _challengeParameters;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x40")]
		private string _session;

		[Token(Token = "0x17000046")]
		public AuthenticationResultType AuthenticationResult
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x10AE294", Offset = "0x10AE294", VA = "0x10AE294")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x10AE29C", Offset = "0x10AE29C", VA = "0x10AE29C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x10AE2B4", Offset = "0x10AE2B4", VA = "0x10AE2B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x10AE2BC", Offset = "0x10AE2BC", VA = "0x10AE2BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Dictionary<string, string> ChallengeParameters
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x10AE340", Offset = "0x10AE340", VA = "0x10AE340")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x10AE348", Offset = "0x10AE348", VA = "0x10AE348")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B734", Offset = "0x1B734")]
		public string Session
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x10AE3AC", Offset = "0x10AE3AC", VA = "0x10AE3AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x10AE3B4", Offset = "0x10AE3B4", VA = "0x10AE3B4")]
			set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x10AE2A4", Offset = "0x10AE2A4", VA = "0x10AE2A4")]
		internal bool IsSetAuthenticationResult()
		{
			return default;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x10AE2C4", Offset = "0x10AE2C4", VA = "0x10AE2C4")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x10AE350", Offset = "0x10AE350", VA = "0x10AE350")]
		internal bool IsSetChallengeParameters()
		{
			return default;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x10AE3BC", Offset = "0x10AE3BC", VA = "0x10AE3BC")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x10AE3CC", Offset = "0x10AE3CC", VA = "0x10AE3CC")]
		public AdminInitiateAuthResponse()
		{
		}
	}
}
