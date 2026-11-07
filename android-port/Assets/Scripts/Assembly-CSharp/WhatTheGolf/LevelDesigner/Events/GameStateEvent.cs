using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012B5")]
	public class GameStateEvent : BaseEvent<GameStateEvent.GameStateEventType>
	{
		[Token(Token = "0x20012B6")]
		public enum GameStateEventType
		{
			[Token(Token = "0x40064EC")]
			Empty = 0,
			[Token(Token = "0x40064ED")]
			SetStateTest = 1,
			[Token(Token = "0x40064EE")]
			SetStateEdit = 2,
			[Token(Token = "0x40064EF")]
			SetStatePlay = 3,
			[Token(Token = "0x40064F0")]
			SetStateGolflix = 4,
			[Token(Token = "0x40064F1")]
			OnSelectObject = 5,
			[Token(Token = "0x40064F2")]
			OnRequireUnloadLevel = 6
		}

		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x147F7D4", Offset = "0x147F7D4", VA = "0x147F7D4")]
		public GameStateEvent(GameStateEventType eventType, [Optional] object data)
		{
		}
	}
}
