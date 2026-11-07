using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x2000394")]
	public interface IRegistrar<T> where T : class
	{
		[Token(Token = "0x6001B97")]
		void Register(T registrant);

		[Token(Token = "0x6001B98")]
		void Deregister(T registrant);
	}
}
