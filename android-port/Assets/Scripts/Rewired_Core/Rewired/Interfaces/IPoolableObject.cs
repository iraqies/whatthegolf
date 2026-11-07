using System;
using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000180")]
	public interface IPoolableObject : IDisposable
	{
		[Token(Token = "0x6000C57")]
		void Return();
	}
}
