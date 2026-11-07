using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x200008D")]
	public interface IApplicationSettings
	{
		[Token(Token = "0x600054F")]
		void SetValue(string key, string value, ApplicationSettingsMode mode);

		[Token(Token = "0x6000550")]
		string GetValue(string key, ApplicationSettingsMode mode);

		[Token(Token = "0x6000551")]
		void RemoveValue(string key, ApplicationSettingsMode mode);
	}
}
