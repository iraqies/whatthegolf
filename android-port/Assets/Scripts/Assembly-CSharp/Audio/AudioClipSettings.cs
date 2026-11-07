using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x20013B6")]
	public class AudioClipSettings
	{
		[Token(Token = "0x20013B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48FBC", Offset = "0x48FBC")]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x4006A21")]
			[FieldOffset(Offset = "0x10")]
			public PlayClipInfo info;

			[Token(Token = "0x4006A22")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 position;

			[Token(Token = "0x6005C0B")]
			[Address(RVA = "0x176F910", Offset = "0x176F910", VA = "0x176F910")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6005C0C")]
			[Address(RVA = "0x176F918", Offset = "0x176F918", VA = "0x176F918")]
			internal void _003CPlay_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x4006A1A")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip clip;

		[Token(Token = "0x4006A1B")]
		[FieldOffset(Offset = "0x18")]
		public AudioUtility.AudioManagerVoice voice;

		[Token(Token = "0x4006A1C")]
		[FieldOffset(Offset = "0x20")]
		public AudioAttribute Volume;

		[Token(Token = "0x4006A1D")]
		[FieldOffset(Offset = "0x30")]
		public AudioAttribute Pitch;

		[Token(Token = "0x4006A1E")]
		[FieldOffset(Offset = "0x40")]
		public float Weight;

		[Token(Token = "0x4006A1F")]
		[FieldOffset(Offset = "0x44")]
		public bool IsWeighted;

		[Token(Token = "0x4006A20")]
		[FieldOffset(Offset = "0x48")]
		private AudioSources m_ActualVoice;

		[Token(Token = "0x6005C05")]
		[Address(RVA = "0x142C974", Offset = "0x142C974", VA = "0x142C974")]
		public AudioClipSettings(AudioClip clip, AudioAttribute volume, AudioAttribute pitch)
		{
		}

		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x142CA6C", Offset = "0x142CA6C", VA = "0x142CA6C")]
		public AudioClipSettings(AudioClip clip)
		{
		}

		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x142CB30", Offset = "0x142CB30", VA = "0x142CB30")]
		public AudioClipSettings()
		{
		}

		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x142CB38", Offset = "0x142CB38", VA = "0x142CB38", Slot = "4")]
		public PlayClipInfo GetPlayInfo()
		{
			return default;
		}

		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x142CBB8", Offset = "0x142CBB8", VA = "0x142CBB8")]
		public AudioSource Play(AudioSources voice, Vector3 position, float delay = 0f)
		{
			return null;
		}

		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x142CD1C", Offset = "0x142CD1C", VA = "0x142CD1C")]
		public AudioSource Play(Vector3 position, float delay = 0f)
		{
			return null;
		}
	}
}
