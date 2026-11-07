using System;
using Il2CppDummyDll;

namespace Agens.Stickers
{
	[Serializable]
	[Token(Token = "0x2001018")]
	public class SigningSettings
	{
		[Token(Token = "0x40054D1")]
		[FieldOffset(Offset = "0x10")]
		public bool AutomaticSigning;

		[Token(Token = "0x40054D2")]
		[FieldOffset(Offset = "0x18")]
		public string ProvisioningProfile;

		[Token(Token = "0x40054D3")]
		[FieldOffset(Offset = "0x20")]
		public string ProvisioningProfileSpecifier;

		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x16A8DD4", Offset = "0x16A8DD4", VA = "0x16A8DD4")]
		public SigningSettings()
		{
		}
	}
}
