using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001357")]
	public class AudioOnCarDrift : MonoBehaviour
	{
		[Token(Token = "0x2001358")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x48CBC", Offset = "0x48CBC")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x400678B")]
			[FieldOffset(Offset = "0x10")]
			public AudioOnCarDrift _003C_003E4__this;

			[Token(Token = "0x400678C")]
			[FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400678D")]
			[FieldOffset(Offset = "0x1C")]
			public float pitch;

			[Token(Token = "0x6005A40")]
			[Address(RVA = "0x176FD8C", Offset = "0x176FD8C", VA = "0x176FD8C")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6005A41")]
			[Address(RVA = "0x176FD94", Offset = "0x176FD94", VA = "0x176FD94")]
			internal void _003COnCreateSkidmark_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x4006777")]
		[FieldOffset(Offset = "0x18")]
		public float skidIntensity;

		[Token(Token = "0x4006778")]
		[FieldOffset(Offset = "0x20")]
		public Skidmarks skid;

		[Token(Token = "0x4006779")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rigid;

		[Token(Token = "0x400677A")]
		[FieldOffset(Offset = "0x30")]
		public GolfCarShooter car;

		[Token(Token = "0x400677B")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve amplitude;

		[Token(Token = "0x400677C")]
		[FieldOffset(Offset = "0x40")]
		public float maxLoopVolume;

		[Token(Token = "0x400677D")]
		[FieldOffset(Offset = "0x44")]
		public float minLoopPitch;

		[Token(Token = "0x400677E")]
		[FieldOffset(Offset = "0x48")]
		public float maxLoopPitch;

		[Token(Token = "0x400677F")]
		[FieldOffset(Offset = "0x50")]
		public List<AudioClip> oneshots;

		[Token(Token = "0x4006780")]
		[FieldOffset(Offset = "0x58")]
		public float minIntensity;

		[Token(Token = "0x4006781")]
		[FieldOffset(Offset = "0x5C")]
		public float maxIntensity;

		[Token(Token = "0x4006782")]
		[FieldOffset(Offset = "0x60")]
		public float minVolume;

		[Token(Token = "0x4006783")]
		[FieldOffset(Offset = "0x64")]
		public float maxVolume;

		[Token(Token = "0x4006784")]
		[FieldOffset(Offset = "0x68")]
		public float minPitch;

		[Token(Token = "0x4006785")]
		[FieldOffset(Offset = "0x6C")]
		public float maxPitch;

		[Token(Token = "0x4006786")]
		[FieldOffset(Offset = "0x70")]
		public float cooldown;

		[Token(Token = "0x4006787")]
		[FieldOffset(Offset = "0x78")]
		private AudioSource source;

		[Token(Token = "0x4006788")]
		[FieldOffset(Offset = "0x80")]
		private AudioPitchToTimeScale timeScalePitcher;

		[Token(Token = "0x4006789")]
		[FieldOffset(Offset = "0x88")]
		private float nextOneshotTime;

		[Token(Token = "0x400678A")]
		[FieldOffset(Offset = "0x8C")]
		private float targetIntensity;

		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0x1509750", Offset = "0x1509750", VA = "0x1509750")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x15097D0", Offset = "0x15097D0", VA = "0x15097D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x15098F8", Offset = "0x15098F8", VA = "0x15098F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x1509A20", Offset = "0x1509A20", VA = "0x1509A20")]
		private void Update()
		{
		}

		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x1509B58", Offset = "0x1509B58", VA = "0x1509B58")]
		private void OnCreateSkidmark(float intensity)
		{
		}

		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x1509F78", Offset = "0x1509F78", VA = "0x1509F78")]
		public AudioOnCarDrift()
		{
		}
	}
}
