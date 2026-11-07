using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000034")]
	public interface IAllocationStrategy
	{
		[Token(Token = "0x600013C")]
		object New(Type type, int typeHash);

		[Token(Token = "0x600013D")]
		void Release(int typeHash, object obj);
	}
}
