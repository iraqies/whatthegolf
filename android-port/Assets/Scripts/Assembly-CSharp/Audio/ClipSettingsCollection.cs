using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x20013BC")]
	public class ClipSettingsCollection : IPlayableClipCollection, IWeightedCollection
	{
		[Token(Token = "0x4006A33")]
		[FieldOffset(Offset = "0x10")]
		public AudioAttribute Volume;

		[Token(Token = "0x4006A34")]
		[FieldOffset(Offset = "0x20")]
		public AudioAttribute Pitch;

		[Token(Token = "0x4006A35")]
		[FieldOffset(Offset = "0x30")]
		public CollectionPlayMode PlayMode;

		[Token(Token = "0x4006A36")]
		[FieldOffset(Offset = "0x38")]
		public List<AudioClipSettings> Clips;

		[Token(Token = "0x4006A37")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AA7C", Offset = "0x5AA7C")]
		private int LastCollectionIndex__BackingField;

		[Token(Token = "0x4006A38")]
		[FieldOffset(Offset = "0x48")]
		private AudioSource m_lastAudioSource;

		[Token(Token = "0x4006A39")]
		[FieldOffset(Offset = "0x50")]
		private PlayClipInfo m_lastClipInfo;

		[Token(Token = "0x4006A3A")]
		[FieldOffset(Offset = "0x68")]
		private float[] weights;

		[Token(Token = "0x17000A60")]
		public CollectionPlayMode GetPlayMode
		{
			[Token(Token = "0x6005C18")]
			[Address(RVA = "0x18A06D0", Offset = "0x18A06D0", VA = "0x18A06D0", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A61")]
		public int LastCollectionIndex
		{
			[Token(Token = "0x6005C19")]
			[Address(RVA = "0x18A06D8", Offset = "0x18A06D8", VA = "0x18A06D8", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x727A0", Offset = "0x727A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005C1A")]
			[Address(RVA = "0x18A06E0", Offset = "0x18A06E0", VA = "0x18A06E0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x727B0", Offset = "0x727B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A62")]
		public int Count
		{
			[Token(Token = "0x6005C1B")]
			[Address(RVA = "0x18A06E8", Offset = "0x18A06E8", VA = "0x18A06E8", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A63")]
		public AudioSource LastAudioSource
		{
			[Token(Token = "0x6005C1C")]
			[Address(RVA = "0x18A0734", Offset = "0x18A0734", VA = "0x18A0734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A64")]
		public PlayClipInfo LastClipInfo
		{
			[Token(Token = "0x6005C1D")]
			[Address(RVA = "0x18A073C", Offset = "0x18A073C", VA = "0x18A073C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A65")]
		public float[] GetWeights
		{
			[Token(Token = "0x6005C1E")]
			[Address(RVA = "0x18A0750", Offset = "0x18A0750", VA = "0x18A0750", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0x18A0864", Offset = "0x18A0864", VA = "0x18A0864")]
		public PlayClipInfo GetPlayInfo()
		{
			return default;
		}

		[Token(Token = "0x6005C20")]
		[Address(RVA = "0x18A099C", Offset = "0x18A099C", VA = "0x18A099C")]
		public void Play(Vector3 position, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x18A0AA0", Offset = "0x18A0AA0", VA = "0x18A0AA0")]
		public void PlayDelayed(Vector3 position, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x18A0BB0", Offset = "0x18A0BB0", VA = "0x18A0BB0")]
		public void PlayDelayed(Vector3 position, AudioSources voice, float delay, float volumeModifier = 1f, float pitchModifier = 1f)
		{
		}

		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x18A0C5C", Offset = "0x18A0C5C", VA = "0x18A0C5C")]
		public void Play(AudioSources voice, Vector3 position, float delay = 0f)
		{
		}

		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x18A0C70", Offset = "0x18A0C70", VA = "0x18A0C70")]
		public void Play(AudioSources voice, Vector3 position, float volumeModifier, float pitchModifier, float delay = 0f, bool disableSpatial = false)
		{
		}

		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x18A0D68", Offset = "0x18A0D68", VA = "0x18A0D68")]
		public ClipSettingsCollection()
		{
		}
	}
}
