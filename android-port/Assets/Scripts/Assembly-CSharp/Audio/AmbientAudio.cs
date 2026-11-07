using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Token(Token = "0x2001349")]
	public class AmbientAudio : MonoBehaviour, IEquatable<AmbientAudio>
	{
		[Token(Token = "0x200134A")]
		public enum Fade
		{
			[Token(Token = "0x4006751")]
			None = 0,
			[Token(Token = "0x4006752")]
			Down = 1,
			[Token(Token = "0x4006753")]
			Up = 2
		}

		[Token(Token = "0x400673E")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip clip;

		[Token(Token = "0x400673F")]
		[FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x4006740")]
		[FieldOffset(Offset = "0x28")]
		public bool startRandom;

		[Token(Token = "0x4006741")]
		[FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4006742")]
		[FieldOffset(Offset = "0x30")]
		public float pitch;

		[Token(Token = "0x4006743")]
		[FieldOffset(Offset = "0x34")]
		public float fadeTime;

		[Token(Token = "0x4006744")]
		[FieldOffset(Offset = "0x38")]
		public float timeScalePitchAmount;

		[Token(Token = "0x4006745")]
		[FieldOffset(Offset = "0x40")]
		public List<AudioClip> oneShotAmbients;

		[Token(Token = "0x4006746")]
		[FieldOffset(Offset = "0x48")]
		public float oneShotIntervalWaitMax;

		[Token(Token = "0x4006747")]
		[FieldOffset(Offset = "0x4C")]
		public float oneShotIntervalWaitMin;

		[Token(Token = "0x4006748")]
		[FieldOffset(Offset = "0x50")]
		public float oneShotVolumeMin;

		[Token(Token = "0x4006749")]
		[FieldOffset(Offset = "0x54")]
		public float oneShotVolumeMax;

		[Token(Token = "0x400674A")]
		[FieldOffset(Offset = "0x58")]
		public Fade currentFade;

		[Token(Token = "0x400674B")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59E8C", Offset = "0x59E8C")]
		private float Gain__BackingField;

		[Token(Token = "0x400674C")]
		[FieldOffset(Offset = "0x60")]
		public Action onKill;

		[Token(Token = "0x400674D")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59E9C", Offset = "0x59E9C")]
		private float nextOneShotAmbient__BackingField;

		[Token(Token = "0x400674E")]
		[FieldOffset(Offset = "0x70")]
		private AudioSource lastOneshotSource;

		[Token(Token = "0x400674F")]
		[FieldOffset(Offset = "0x78")]
		private AudioClip lastOneshotClip;

		[Token(Token = "0x17000A28")]
		public float Gain
		{
			[Token(Token = "0x6005A09")]
			[Address(RVA = "0x140D70C", Offset = "0x140D70C", VA = "0x140D70C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72248", Offset = "0x72248")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A0A")]
			[Address(RVA = "0x140D714", Offset = "0x140D714", VA = "0x140D714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72258", Offset = "0x72258")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A29")]
		public float nextOneShotAmbient
		{
			[Token(Token = "0x6005A0B")]
			[Address(RVA = "0x140D71C", Offset = "0x140D71C", VA = "0x140D71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72268", Offset = "0x72268")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A0C")]
			[Address(RVA = "0x140D724", Offset = "0x140D724", VA = "0x140D724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72278", Offset = "0x72278")]
			set
			{
			}
		}

		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x140D72C", Offset = "0x140D72C", VA = "0x140D72C")]
		public void OnSceneStart()
		{
		}

		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x140D770", Offset = "0x140D770", VA = "0x140D770")]
		public void UpdateAmbient()
		{
		}

		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x140DA64", Offset = "0x140DA64", VA = "0x140DA64", Slot = "4")]
		public bool Equals(AmbientAudio other)
		{
			return default;
		}

		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x140DAF4", Offset = "0x140DAF4", VA = "0x140DAF4")]
		public AmbientAudio()
		{
		}

		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x140DB34", Offset = "0x140DB34", VA = "0x140DB34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72288", Offset = "0x72288")]
		private void _003CUpdateAmbient_003Eb__26_0(AudioSource s)
		{
		}
	}
}
