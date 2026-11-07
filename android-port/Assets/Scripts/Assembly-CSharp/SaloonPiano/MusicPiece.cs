using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SaloonPiano
{
	[Token(Token = "0x2001091")]
	public class MusicPiece : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2001092")]
		public class NoteData
		{
			[Token(Token = "0x400571B")]
			[FieldOffset(Offset = "0x10")]
			public int beat;

			[Token(Token = "0x400571C")]
			[FieldOffset(Offset = "0x14")]
			public int position;

			[Token(Token = "0x400571D")]
			[FieldOffset(Offset = "0x18")]
			public AudioClip clip;

			[Token(Token = "0x400571E")]
			[FieldOffset(Offset = "0x20")]
			public bool isWrong;

			[Token(Token = "0x6004A42")]
			[Address(RVA = "0x18053B4", Offset = "0x18053B4", VA = "0x18053B4")]
			public NoteData()
			{
			}
		}

		[Token(Token = "0x4005717")]
		[FieldOffset(Offset = "0x18")]
		public int length;

		[Token(Token = "0x4005718")]
		[FieldOffset(Offset = "0x1C")]
		public int minPosition;

		[Token(Token = "0x4005719")]
		[FieldOffset(Offset = "0x20")]
		public int maxPosition;

		[Token(Token = "0x400571A")]
		[FieldOffset(Offset = "0x28")]
		public NoteData[] notes;

		[Token(Token = "0x6004A41")]
		[Address(RVA = "0x1587D9C", Offset = "0x1587D9C", VA = "0x1587D9C")]
		public MusicPiece()
		{
		}
	}
}
