using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x2000095")]
	public class ApplicationSettings : IApplicationSettings
	{
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11CEA1C", Offset = "0x11CEA1C", VA = "0x11CEA1C", Slot = "4")]
		public void SetValue(string key, string value, ApplicationSettingsMode mode)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11CEA70", Offset = "0x11CEA70", VA = "0x11CEA70", Slot = "5")]
		public string GetValue(string key, ApplicationSettingsMode mode)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11CEAC4", Offset = "0x11CEAC4", VA = "0x11CEAC4", Slot = "6")]
		public void RemoveValue(string key, ApplicationSettingsMode mode)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11CEB18", Offset = "0x11CEB18", VA = "0x11CEB18")]
		public ApplicationSettings()
		{
		}
	}
}
