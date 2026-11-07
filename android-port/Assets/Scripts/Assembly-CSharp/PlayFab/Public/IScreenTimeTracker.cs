using Il2CppDummyDll;

namespace PlayFab.Public
{
	[Token(Token = "0x20011B4")]
	public interface IScreenTimeTracker
	{
		[Token(Token = "0x60050E0")]
		void OnEnable();

		[Token(Token = "0x60050E1")]
		void OnDisable();

		[Token(Token = "0x60050E2")]
		void OnDestroy();

		[Token(Token = "0x60050E3")]
		void OnApplicationQuit();

		[Token(Token = "0x60050E4")]
		void OnApplicationFocus(bool isFocused);

		[Token(Token = "0x60050E5")]
		void ClientSessionStart(string entityId, string entityType, string playFabUserId);

		[Token(Token = "0x60050E6")]
		void Send();
	}
}
