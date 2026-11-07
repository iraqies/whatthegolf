using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Serializable]
	[Token(Token = "0x20013FB")]
	public class RumbleFileSetting
	{
		[Token(Token = "0x4006B4A")]
		[FieldOffset(Offset = "0x10")]
		public TextAsset rumbleFile;

		[Token(Token = "0x4006B4B")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip ps5HapticsAudioClip;

		[Token(Token = "0x4006B4C")]
		[FieldOffset(Offset = "0x20")]
		public float[] vibrationData;

		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x1661CA8", Offset = "0x1661CA8", VA = "0x1661CA8")]
		public RumbleFileSetting()
		{
		}
	}
}
