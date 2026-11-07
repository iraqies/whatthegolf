using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Settings
{
	[Token(Token = "0x200023B")]
	public interface IPersistenceManager
	{
		[Token(Token = "0x6001100")]
		SettingsCollection GetSettings(string type);

		[Token(Token = "0x6001101")]
		void SaveSettings(string type, SettingsCollection settings);
	}
}
