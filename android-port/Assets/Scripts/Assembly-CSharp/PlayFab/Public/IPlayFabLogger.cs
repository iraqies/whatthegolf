using Il2CppDummyDll;

namespace PlayFab.Public
{
	[Token(Token = "0x20011B6")]
	public interface IPlayFabLogger
	{
		[Token(Token = "0x60050F1")]
		void OnEnable();

		[Token(Token = "0x60050F2")]
		void OnDisable();

		[Token(Token = "0x60050F3")]
		void OnDestroy();
	}
}
