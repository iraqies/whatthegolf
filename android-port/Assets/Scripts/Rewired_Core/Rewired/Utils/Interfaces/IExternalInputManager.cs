using Il2CppDummyDll;
using Rewired.Platforms;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000395")]
	public interface IExternalInputManager
	{
		[Token(Token = "0x6001B99")]
		object Initialize(Platform platform, object configVars);

		[Token(Token = "0x6001B9A")]
		void Deinitialize();
	}
}
