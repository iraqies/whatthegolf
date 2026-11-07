using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement.Internal
{
	[Token(Token = "0x2000144")]
	public class SAMLRoleSessionManager
	{
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x10")]
		private SettingsManager settingsManager;

		[Token(Token = "0x170002A7")]
		public static bool IsAvailable
		{
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x126EBDC", Offset = "0x126EBDC", VA = "0x126EBDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x126EBE4", Offset = "0x126EBE4", VA = "0x126EBE4")]
		public SAMLRoleSessionManager()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x126ECA4", Offset = "0x126ECA4", VA = "0x126ECA4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x126F060", Offset = "0x126F060", VA = "0x126F060")]
		public bool TryGetRoleSession(string roleSessionName, out SAMLImmutableCredentials credentials)
		{
			return default;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x126F678", Offset = "0x126F678", VA = "0x126F678")]
		public void RegisterRoleSession(string roleSessionName, SAMLImmutableCredentials credentials)
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x126F9CC", Offset = "0x126F9CC", VA = "0x126F9CC")]
		public void UnregisterRoleSession(string roleSessionName)
		{
		}
	}
}
