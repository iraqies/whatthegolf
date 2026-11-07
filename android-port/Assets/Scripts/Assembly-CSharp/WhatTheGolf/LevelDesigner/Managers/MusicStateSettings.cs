using System;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Serializable]
	[Token(Token = "0x20012C2")]
	public struct MusicStateSettings
	{
		[Token(Token = "0x4006507")]
		[FieldOffset(Offset = "0x0")]
		public LevelMusicSettings musicData;

		[Token(Token = "0x4006508")]
		[FieldOffset(Offset = "0x8")]
		public float rtpcInEditMode;

		[Token(Token = "0x4006509")]
		[FieldOffset(Offset = "0xC")]
		public float rtpcInPlaymode;

		[Token(Token = "0x400650A")]
		[FieldOffset(Offset = "0x10")]
		public int transitionTimeToPlaymode;

		[Token(Token = "0x400650B")]
		[FieldOffset(Offset = "0x14")]
		public int transitionTimeToEditmode;
	}
}
