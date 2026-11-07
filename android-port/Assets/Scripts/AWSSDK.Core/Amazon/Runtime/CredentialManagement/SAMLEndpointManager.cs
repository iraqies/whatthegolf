using System.Collections.Generic;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x200013B")]
	public class SAMLEndpointManager
	{
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x10")]
		private NamedSettingsManager settingsManager;

		[Token(Token = "0x170002A5")]
		public static bool IsAvailable
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x126B2AC", Offset = "0x126B2AC", VA = "0x126B2AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x126B224", Offset = "0x126B224", VA = "0x126B224")]
		public SAMLEndpointManager()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x126B2B4", Offset = "0x126B2B4", VA = "0x126B2B4")]
		public void RegisterEndpoint(SAMLEndpoint samlEndpoint)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x126B434", Offset = "0x126B434", VA = "0x126B434")]
		public bool TryGetEndpoint(string endpointName, out SAMLEndpoint samlEndpoint)
		{
			return default;
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x126B5F4", Offset = "0x126B5F4", VA = "0x126B5F4")]
		public SAMLEndpoint GetEndpoint(string endpointName)
		{
			return null;
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x126B954", Offset = "0x126B954", VA = "0x126B954")]
		public void UnregisterEndpoint(string endpointName)
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x126B970", Offset = "0x126B970", VA = "0x126B970")]
		public List<string> ListEndpointNames()
		{
			return null;
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x126B98C", Offset = "0x126B98C", VA = "0x126B98C")]
		public List<SAMLEndpoint> ListEndpoints()
		{
			return null;
		}
	}
}
