using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200136F")]
	public class PlayClipOnAudioEvent : AudioEventListenerBase, ISpatializeDisable
	{
		[Serializable]
		[Token(Token = "0x2001370")]
		public class Overrides
		{
			[Token(Token = "0x4006829")]
			[FieldOffset(Offset = "0x10")]
			public bool overrideVoice;

			[Token(Token = "0x400682A")]
			[FieldOffset(Offset = "0x14")]
			public AudioUtility.AudioManagerVoice voice;

			[Token(Token = "0x400682B")]
			[FieldOffset(Offset = "0x18")]
			public bool overrideVolume;

			[Token(Token = "0x400682C")]
			[FieldOffset(Offset = "0x20")]
			public AudioAttribute volume;

			[Token(Token = "0x400682D")]
			[FieldOffset(Offset = "0x30")]
			public bool overridePitch;

			[Token(Token = "0x400682E")]
			[FieldOffset(Offset = "0x38")]
			public AudioAttribute pitch;

			[Token(Token = "0x400682F")]
			[FieldOffset(Offset = "0x48")]
			public bool overrideCooldown;

			[Token(Token = "0x4006830")]
			[FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A4E0", Offset = "0x5A4E0")]
			public float cooldown;

			[Token(Token = "0x4006831")]
			[FieldOffset(Offset = "0x50")]
			public bool overrideDelay;

			[Token(Token = "0x4006832")]
			[FieldOffset(Offset = "0x54")]
			public float delay;

			[Token(Token = "0x6005ACF")]
			[Address(RVA = "0x1827954", Offset = "0x1827954", VA = "0x1827954")]
			public Overrides()
			{
			}
		}

		[Token(Token = "0x4006824")]
		[FieldOffset(Offset = "0x28")]
		public AudioEventAsset asset;

		[Token(Token = "0x4006825")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Overrides overrides;

		[Token(Token = "0x4006826")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected bool disableSpatialOnMultiplayer;

		[Token(Token = "0x4006827")]
		[FieldOffset(Offset = "0x40")]
		private AudioSources audioManagerVoice;

		[Token(Token = "0x4006828")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A4D0", Offset = "0x5A4D0")]
		private bool DisableSpatial__BackingField;

		[Token(Token = "0x17000A43")]
		public bool DisableSpatial
		{
			[Token(Token = "0x6005AC8")]
			[Address(RVA = "0x15E9B94", Offset = "0x15E9B94", VA = "0x15E9B94", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72448", Offset = "0x72448")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005AC9")]
			[Address(RVA = "0x15E9B9C", Offset = "0x15E9B9C", VA = "0x15E9B9C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72458", Offset = "0x72458")]
			set
			{
			}
		}

		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x15E9BA4", Offset = "0x15E9BA4", VA = "0x15E9BA4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x15E9C38", Offset = "0x15E9C38", VA = "0x15E9C38", Slot = "7")]
		public override void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}

		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0x15E9D30", Offset = "0x15E9D30", VA = "0x15E9D30", Slot = "6")]
		public override void Play(Vector3 position)
		{
		}

		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0x15E9D44", Offset = "0x15E9D44", VA = "0x15E9D44", Slot = "5")]
		public override void Play()
		{
		}

		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0x15E9D8C", Offset = "0x15E9D8C", VA = "0x15E9D8C")]
		public PlayClipOnAudioEvent()
		{
		}
	}
}
