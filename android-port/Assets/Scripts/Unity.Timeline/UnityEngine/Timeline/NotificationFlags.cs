using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Serializable]
	[Token(Token = "0x200002D")]
	[Flags]
	public enum NotificationFlags : short
	{
		[Token(Token = "0x40000CD")]
		TriggerInEditMode = 1,
		[Token(Token = "0x40000CE")]
		Retroactive = 2,
		[Token(Token = "0x40000CF")]
		TriggerOnce = 4
	}
}
