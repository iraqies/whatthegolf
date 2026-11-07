using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x2001392")]
	public class AudioClipFromVelocity
	{
		[Token(Token = "0x2001393")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48EAC", Offset = "0x48EAC")]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			[Token(Token = "0x4006911")]
			[FieldOffset(Offset = "0x10")]
			public AudioClipFromVelocity _003C_003E4__this;

			[Token(Token = "0x4006912")]
			[FieldOffset(Offset = "0x18")]
			public float pct;

			[Token(Token = "0x6005B55")]
			[Address(RVA = "0x176F884", Offset = "0x176F884", VA = "0x176F884")]
			public _003C_003Ec__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6005B56")]
			[Address(RVA = "0x176F88C", Offset = "0x176F88C", VA = "0x176F88C")]
			internal void _003CSetSoundValues_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x400690A")]
		[FieldOffset(Offset = "0x10")]
		public List<AudioClip> clips;

		[Token(Token = "0x400690B")]
		[FieldOffset(Offset = "0x18")]
		public float minVelocity;

		[Token(Token = "0x400690C")]
		[FieldOffset(Offset = "0x1C")]
		public float maxVelocity;

		[Token(Token = "0x400690D")]
		[FieldOffset(Offset = "0x20")]
		public float minVolume;

		[Token(Token = "0x400690E")]
		[FieldOffset(Offset = "0x24")]
		public float maxVolume;

		[Token(Token = "0x400690F")]
		[FieldOffset(Offset = "0x28")]
		public float minPitch;

		[Token(Token = "0x4006910")]
		[FieldOffset(Offset = "0x2C")]
		public float maxPitch;

		[Token(Token = "0x6005B53")]
		[Address(RVA = "0x142C848", Offset = "0x142C848", VA = "0x142C848")]
		public void SetSoundValues(float velocity, out Action<AudioSource> modifier)
		{
		}

		[Token(Token = "0x6005B54")]
		[Address(RVA = "0x142C944", Offset = "0x142C944", VA = "0x142C944")]
		public AudioClipFromVelocity()
		{
		}
	}
}
