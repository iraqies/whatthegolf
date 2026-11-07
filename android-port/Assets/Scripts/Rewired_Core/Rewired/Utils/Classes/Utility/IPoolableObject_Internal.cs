using System;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x200035E")]
	internal interface IPoolableObject_Internal : IDisposable, IPoolableObject
	{
		[Token(Token = "0x170006BF")]
		IObjectPool pool
		{
			[Token(Token = "0x60019CC")]
			set;
		}

		[Token(Token = "0x60019CD")]
		void Clear();
	}
}
