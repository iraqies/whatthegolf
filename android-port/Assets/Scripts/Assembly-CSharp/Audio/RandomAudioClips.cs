using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Serializable]
	[Token(Token = "0x20013A4")]
	public class RandomAudioClips
	{
		[Token(Token = "0x20013A5")]
		public enum Voice
		{
			[Token(Token = "0x40069C3")]
			ShortEffects = 0,
			[Token(Token = "0x40069C4")]
			UI = 1,
			[Token(Token = "0x40069C5")]
			Ambience = 2
		}

		[Token(Token = "0x20013A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48ECC", Offset = "0x48ECC")]
		private sealed class _003C_003Ec__DisplayClass37_0
		{
			[Token(Token = "0x40069C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RandomAudioClips _003C_003E4__this;

			[Token(Token = "0x40069C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volMod;

			[Token(Token = "0x40069C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float pitchMod;

			[Token(Token = "0x40069C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x6005BC4")]
			[Address(RVA = "0x183022C", Offset = "0x183022C", VA = "0x183022C")]
			public _003C_003Ec__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6005BC5")]
			[Address(RVA = "0x1830234", Offset = "0x1830234", VA = "0x1830234")]
			internal void _003CSetModifier_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x40069A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AudioMixerGroup outputGroup;

		[Token(Token = "0x40069A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool nonRepeating;

		[Token(Token = "0x40069A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool playInOrder;

		[Token(Token = "0x40069A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AudioClip> clips;

		[Token(Token = "0x40069A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClipSettingsCollection collection;

		[Token(Token = "0x40069A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool useSourceSettings;

		[Token(Token = "0x40069AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool overrideVolume;

		[Token(Token = "0x40069AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float baseVolume;

		[Token(Token = "0x40069AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float volumeDeviance;

		[Token(Token = "0x40069AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float volumeVelocityBonus;

		[Token(Token = "0x40069AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool overridePitch;

		[Token(Token = "0x40069AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float basePitch;

		[Token(Token = "0x40069B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float pitchDeviance;

		[Token(Token = "0x40069B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float pitchVelocityBonus;

		[Token(Token = "0x40069B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool overrideAttenuation;

		[Token(Token = "0x40069B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve attenuation;

		[Token(Token = "0x40069B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float maxDistance;

		[Token(Token = "0x40069B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool overrideDoppler;

		[Token(Token = "0x40069B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A810", Offset = "0x5A810")]
		[SerializeField]
		private float doppler;

		[Token(Token = "0x40069B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool overrideSpread;

		[Token(Token = "0x40069B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A860", Offset = "0x5A860")]
		[SerializeField]
		private float spread;

		[Token(Token = "0x40069B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float delay;

		[Token(Token = "0x40069BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool reverse;

		[Token(Token = "0x40069BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Voice voice;

		[Token(Token = "0x40069BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_VolumeBonus;

		[Token(Token = "0x40069BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_PitchBonus;

		[Token(Token = "0x40069BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int lastIndex;

		[Token(Token = "0x40069BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioSource lastAudioSource;

		[Token(Token = "0x40069C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioClip lastClip;

		[Token(Token = "0x40069C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<AudioSource> mod;

		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x163F62C", Offset = "0x163F62C", VA = "0x163F62C")]
		public void SetReverse(bool reverse)
		{
		}

		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x163F634", Offset = "0x163F634", VA = "0x163F634")]
		public AudioSource GetCurrentAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x163F63C", Offset = "0x163F63C", VA = "0x163F63C")]
		public AudioClip ReturnLastClip()
		{
			return null;
		}

		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x163F644", Offset = "0x163F644", VA = "0x163F644")]
		public void SetVelocityBonus(float volBonus = 0f, float pitchBonus = 0f)
		{
		}

		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x163F64C", Offset = "0x163F64C", VA = "0x163F64C")]
		private AudioClip ReturnRandomClip()
		{
			return null;
		}

		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0x163F774", Offset = "0x163F774", VA = "0x163F774")]
		public void SetModifier(Vector3 position, float volMod, float pitchMod)
		{
		}

		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x163F87C", Offset = "0x163F87C", VA = "0x163F87C")]
		public void PlayRandomClipOnSource(AudioSource s, float volMod, float pitchMod)
		{
		}

		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x163F8D8", Offset = "0x163F8D8", VA = "0x163F8D8")]
		public void PlayRandomClipOnSource(AudioSource s)
		{
		}

		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x163FA3C", Offset = "0x163FA3C", VA = "0x163FA3C")]
		public void PlayRandomClip(Transform obj, float volumeModifier, float pitchModifier)
		{
		}

		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0x163FAA8", Offset = "0x163FAA8", VA = "0x163FAA8")]
		public void PlayRandomClip([Optional] Transform obj)
		{
		}

		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x163FB54", Offset = "0x163FB54", VA = "0x163FB54")]
		public void PlayRandomClip(float volumeModifier, float pitchModifier)
		{
		}

		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x163B744", Offset = "0x163B744", VA = "0x163B744")]
		public void PlayRandomClip(Vector3 pos, float volumeModifier, float pitchModifier)
		{
		}

		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0x163130C", Offset = "0x163130C", VA = "0x163130C")]
		public void PlayRandomClip(Vector3 pos)
		{
		}

		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0x163FBB0", Offset = "0x163FBB0", VA = "0x163FBB0")]
		private void Play(AudioClip clip)
		{
		}

		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0x163FC5C", Offset = "0x163FC5C", VA = "0x163FC5C")]
		public RandomAudioClips()
		{
		}
	}
}
