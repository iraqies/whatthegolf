using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI
{
	[Token(Token = "0x2000323")]
	public interface ITouchInputSource
	{
		[Token(Token = "0x1700068F")]
		bool touchSupported
		{
			[Token(Token = "0x6001855")]
			get;
		}

		[Token(Token = "0x17000690")]
		int touchCount
		{
			[Token(Token = "0x6001856")]
			get;
		}

		[Token(Token = "0x6001857")]
		Touch GetTouch(int index);
	}
}
