using System;
using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x258EC", Offset = "0x258EC")]
	public class SAMLEndpointSettings : ProfileSettingsBase
	{
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string DefaultAuthenticationType;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26518", Offset = "0x26518")]
		private Uri Endpoint__BackingField;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x28")]
		private string _authenticationType;

		[Token(Token = "0x170000F8")]
		public Uri Endpoint
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x126BB64", Offset = "0x126BB64", VA = "0x126BB64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x285FC", Offset = "0x285FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x126BB6C", Offset = "0x126BB6C", VA = "0x126BB6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2860C", Offset = "0x2860C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public string AuthenticationType
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x126BB74", Offset = "0x126BB74", VA = "0x126BB74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x126BBEC", Offset = "0x126BBEC", VA = "0x126BBEC")]
		public static bool CanCreateFrom(string endpointName)
		{
			return default;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x126BEB8", Offset = "0x126BEB8", VA = "0x126BEB8")]
		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return default;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x126BF28", Offset = "0x126BF28", VA = "0x126BF28")]
		public static SAMLEndpointSettings LoadFrom(string endpointName)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x126BFA4", Offset = "0x126BFA4", VA = "0x126BFA4")]
		public static SAMLEndpointSettings LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x126C4FC", Offset = "0x126C4FC", VA = "0x126C4FC")]
		public static void Validate(string endpointName)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x126C270", Offset = "0x126C270", VA = "0x126C270")]
		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x126C578", Offset = "0x126C578", VA = "0x126C578", Slot = "4")]
		public override string Persist()
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x126C648", Offset = "0x126C648", VA = "0x126C648")]
		public static string Persist(string settingsName, Uri endpoint, string authenticationType)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x126C4A8", Offset = "0x126C4A8", VA = "0x126C4A8")]
		private SAMLEndpointSettings(string settingsName, Uri endpoint, string authenticationType)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x126BCC0", Offset = "0x126BCC0", VA = "0x126BCC0")]
		private static SettingsCollection.ObjectSettings LoadSettings(string endpointName)
		{
			return null;
		}
	}
}
