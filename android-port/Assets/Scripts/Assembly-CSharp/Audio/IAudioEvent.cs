using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001379")]
	public interface IAudioEvent
	{
		[Token(Token = "0x17000A48")]
		Action<Vector3> OnAudioEvent
		{
			[Token(Token = "0x6005AF5")]
			get;
			[Token(Token = "0x6005AF6")]
			set;
		}
	}
}
