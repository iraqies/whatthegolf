using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Serializable]
	[Token(Token = "0x20010EC")]
	public class BeatTrackNote
	{
		[Token(Token = "0x4005930")]
		[FieldOffset(Offset = "0x10")]
		public BeatTrackAction action;

		[Token(Token = "0x4005931")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x160D87C", Offset = "0x160D87C", VA = "0x160D87C")]
		public BeatTrackNote()
		{
		}
	}
}
