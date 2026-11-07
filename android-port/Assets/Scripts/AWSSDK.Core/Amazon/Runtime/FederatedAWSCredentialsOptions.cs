using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000CA")]
	public class FederatedAWSCredentialsOptions
	{
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x10")]
		private readonly object syncLock;

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x18")]
		private Func<CredentialRequestCallbackArgs, NetworkCredential> credentialRequestCallback;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x20")]
		private object customCallbackState;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x28")]
		private string userIdentity;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x30")]
		private string profileName;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x38")]
		private RegionEndpoint stsRegion;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x40")]
		private WebProxy proxySettings;

		[Token(Token = "0x170001D5")]
		public string UserIdentity
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x120B1E8", Offset = "0x120B1E8", VA = "0x120B1E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x120C234", Offset = "0x120C234", VA = "0x120C234")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public Func<CredentialRequestCallbackArgs, NetworkCredential> CredentialRequestCallback
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x120B2C0", Offset = "0x120B2C0", VA = "0x120B2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x120C308", Offset = "0x120C308", VA = "0x120C308")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public object CustomCallbackState
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x120B470", Offset = "0x120B470", VA = "0x120B470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x120C3DC", Offset = "0x120C3DC", VA = "0x120C3DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public WebProxy ProxySettings
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x120BE50", Offset = "0x120BE50", VA = "0x120BE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x120C4B0", Offset = "0x120C4B0", VA = "0x120C4B0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public RegionEndpoint STSRegion
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x120BD78", Offset = "0x120BD78", VA = "0x120BD78")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x120C584", Offset = "0x120C584", VA = "0x120C584")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public string ProfileName
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x120B398", Offset = "0x120B398", VA = "0x120B398")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x120C658", Offset = "0x120C658", VA = "0x120C658")]
			set
			{
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x120AA50", Offset = "0x120AA50", VA = "0x120AA50")]
		public FederatedAWSCredentialsOptions()
		{
		}
	}
}
