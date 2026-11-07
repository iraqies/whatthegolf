using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A8")]
	public class ScheduleAudio
	{
		[Token(Token = "0x40069D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A934", Offset = "0x5A934")]
		private readonly AudioSource[] Players__BackingField;

		[Token(Token = "0x40069D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int flip;

		[Token(Token = "0x17000A57")]
		public AudioSource[] Players
		{
			[Token(Token = "0x6005BC9")]
			[Address(RVA = "0x167B2F0", Offset = "0x167B2F0", VA = "0x167B2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x726D8", Offset = "0x726D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A58")]
		public AudioSource Current
		{
			[Token(Token = "0x6005BCA")]
			[Address(RVA = "0x167B2F8", Offset = "0x167B2F8", VA = "0x167B2F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A59")]
		public bool IsPlaying
		{
			[Token(Token = "0x6005BCB")]
			[Address(RVA = "0x167B340", Offset = "0x167B340", VA = "0x167B340")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x167B390", Offset = "0x167B390", VA = "0x167B390")]
		public ScheduleAudio(Transform playerParent)
		{
		}

		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x167B5B0", Offset = "0x167B5B0", VA = "0x167B5B0")]
		public AudioSource ScheduleNew(AudioClip clip, double startTime, [Optional] Action<AudioSource> modifier)
		{
			return null;
		}

		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x167B744", Offset = "0x167B744", VA = "0x167B744")]
		public void SetVolume(float v)
		{
		}
	}
}
