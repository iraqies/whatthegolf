using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013B8")]
	public struct PlayClipInfo
	{
		[Token(Token = "0x4006A23")]
		[FieldOffset(Offset = "0x0")]
		public AudioClip clip;

		[Token(Token = "0x4006A24")]
		[FieldOffset(Offset = "0x8")]
		public AudioUtility.AudioManagerVoice voice;

		[Token(Token = "0x4006A25")]
		[FieldOffset(Offset = "0xC")]
		public float VolumeResult;

		[Token(Token = "0x4006A26")]
		[FieldOffset(Offset = "0x10")]
		public float PitchResult;
	}
}
