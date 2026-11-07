using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001467")]
	public class OverworldMusicData : ScriptableObject
	{
		[Token(Token = "0x4006FB4")]
		[FieldOffset(Offset = "0x18")]
		public LevelMusicSettings withoutTransition;

		[Token(Token = "0x4006FB5")]
		[FieldOffset(Offset = "0x20")]
		public LevelMusicSettings withTransition;

		[Token(Token = "0x4006FB6")]
		[FieldOffset(Offset = "0x28")]
		public float RTCPMax;

		[Token(Token = "0x4006FB7")]
		[FieldOffset(Offset = "0x2C")]
		public float RTCPMin;

		[Token(Token = "0x4006FB8")]
		[FieldOffset(Offset = "0x30")]
		public float wwiseThreshold;

		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x15C6544", Offset = "0x15C6544", VA = "0x15C6544")]
		public OverworldMusicData()
		{
		}
	}
}
