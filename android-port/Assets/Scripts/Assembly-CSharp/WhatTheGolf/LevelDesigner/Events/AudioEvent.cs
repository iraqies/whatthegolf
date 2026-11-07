using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012A8")]
	public class AudioEvent : BaseEvent<AudioEvent.AudioEventType>
	{
		[Token(Token = "0x20012A9")]
		public enum AudioEventType
		{
			[Token(Token = "0x40064AD")]
			Empty = 0,
			[Token(Token = "0x40064AE")]
			PlaceElement = 1,
			[Token(Token = "0x40064AF")]
			OnBrushStart = 2,
			[Token(Token = "0x40064B0")]
			OnBrushUpdate = 3,
			[Token(Token = "0x40064B1")]
			OnBrushStop = 4,
			[Token(Token = "0x40064B2")]
			OnButtonHoverAny = 5,
			[Token(Token = "0x40064B3")]
			OnButtonDownAny = 6,
			[Token(Token = "0x40064B4")]
			OnObjectHoverAny = 7,
			[Token(Token = "0x40064B5")]
			OnObjectSelectAny = 8,
			[Token(Token = "0x40064B6")]
			OnPublishLevelStart = 9,
			[Token(Token = "0x40064B7")]
			OnPublishLevelSuccess = 10,
			[Token(Token = "0x40064B8")]
			OnPublishLevelFail = 11,
			[Token(Token = "0x40064B9")]
			OnObjectDeleted = 12,
			[Token(Token = "0x40064BA")]
			OnLevelSaved = 13,
			[Token(Token = "0x40064BB")]
			OnLevelDeleted = 14,
			[Token(Token = "0x40064BC")]
			OnUndo = 15,
			[Token(Token = "0x40064BD")]
			OnRedo = 16,
			[Token(Token = "0x40064BE")]
			OnObjectDeleteByEraser = 17,
			[Token(Token = "0x40064BF")]
			OnFail = 18
		}

		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x142D0CC", Offset = "0x142D0CC", VA = "0x142D0CC")]
		public AudioEvent(AudioEventType eventType, [Optional] object data)
		{
		}
	}
}
