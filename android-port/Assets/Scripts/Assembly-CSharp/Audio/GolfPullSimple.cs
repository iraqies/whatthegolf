using System.Collections.Generic;
using Audio.Rumble;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200139D")]
	public class GolfPullSimple : MonoBehaviour
	{
		[Token(Token = "0x400694F")]
		[FieldOffset(Offset = "0x18")]
		public GolfBallController ball;

		[Token(Token = "0x4006950")]
		[FieldOffset(Offset = "0x20")]
		public float minVolume;

		[Token(Token = "0x4006951")]
		[FieldOffset(Offset = "0x24")]
		public float maxVolume;

		[Token(Token = "0x4006952")]
		[FieldOffset(Offset = "0x28")]
		public float minPitch;

		[Token(Token = "0x4006953")]
		[FieldOffset(Offset = "0x2C")]
		public float maxPitch;

		[Token(Token = "0x4006954")]
		[FieldOffset(Offset = "0x30")]
		public float smoothTime;

		[Token(Token = "0x4006955")]
		[FieldOffset(Offset = "0x34")]
		public float gainSmooth;

		[Token(Token = "0x4006956")]
		[FieldOffset(Offset = "0x38")]
		public float minDiff;

		[Token(Token = "0x4006957")]
		[FieldOffset(Offset = "0x40")]
		public ClipSettingsCollection startPullSFX;

		[Token(Token = "0x4006958")]
		[FieldOffset(Offset = "0x48")]
		public ClipSettingsCollection cancelPullSFX;

		[Token(Token = "0x4006959")]
		[FieldOffset(Offset = "0x50")]
		public float oneshotVolume;

		[Token(Token = "0x400695A")]
		[FieldOffset(Offset = "0x54")]
		public float oneshotVolumeDeviance;

		[Token(Token = "0x400695B")]
		[FieldOffset(Offset = "0x58")]
		public float oneshotPitch;

		[Token(Token = "0x400695C")]
		[FieldOffset(Offset = "0x5C")]
		public float oneshotPitchDeviance;

		[Token(Token = "0x400695D")]
		[FieldOffset(Offset = "0x60")]
		public List<AudioClip> openClips;

		[Token(Token = "0x400695E")]
		[FieldOffset(Offset = "0x68")]
		public List<AudioClip> maxClips;

		[Token(Token = "0x400695F")]
		[FieldOffset(Offset = "0x70")]
		public List<AudioClip> closeClips;

		[Token(Token = "0x4006960")]
		[FieldOffset(Offset = "0x78")]
		public RumbleEventAsset shootLowRumble;

		[Token(Token = "0x4006961")]
		[FieldOffset(Offset = "0x80")]
		public RumbleEventAsset shootHighRumble;

		[Token(Token = "0x4006962")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A670", Offset = "0x5A670")]
		private AudioSource source__BackingField;

		[Token(Token = "0x4006963")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A680", Offset = "0x5A680")]
		private AudioSource hapticsSource__BackingField;

		[Token(Token = "0x4006964")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A690", Offset = "0x5A690")]
		private AudioSource gamepadSpeakerSource__BackingField;

		[Token(Token = "0x4006965")]
		[FieldOffset(Offset = "0xA0")]
		private float m_lastBoost;

		[Token(Token = "0x4006966")]
		[FieldOffset(Offset = "0xA4")]
		private float m_smooth;

		[Token(Token = "0x4006967")]
		[FieldOffset(Offset = "0xA8")]
		private float m_lastSmooth;

		[Token(Token = "0x4006968")]
		[FieldOffset(Offset = "0xAC")]
		private float m_target;

		[Token(Token = "0x4006969")]
		[FieldOffset(Offset = "0xB0")]
		private float m_velocity;

		[Token(Token = "0x400696A")]
		[FieldOffset(Offset = "0xB4")]
		private float m_gain;

		[Token(Token = "0x400696B")]
		[FieldOffset(Offset = "0xB8")]
		private float m_gainVelocity;

		[Token(Token = "0x400696C")]
		[FieldOffset(Offset = "0xBC")]
		private bool canPlayCloseClip;

		[Token(Token = "0x400696D")]
		[FieldOffset(Offset = "0xBD")]
		private bool wasCanceled;

		[Token(Token = "0x400696E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _hapticsClip;

		[Token(Token = "0x17000A53")]
		public AudioSource source
		{
			[Token(Token = "0x6005B88")]
			[Address(RVA = "0x14A3B5C", Offset = "0x14A3B5C", VA = "0x14A3B5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72658", Offset = "0x72658")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B89")]
			[Address(RVA = "0x14A3B64", Offset = "0x14A3B64", VA = "0x14A3B64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72668", Offset = "0x72668")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A54")]
		public AudioSource hapticsSource
		{
			[Token(Token = "0x6005B8A")]
			[Address(RVA = "0x14A3B6C", Offset = "0x14A3B6C", VA = "0x14A3B6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72678", Offset = "0x72678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B8B")]
			[Address(RVA = "0x14A3B74", Offset = "0x14A3B74", VA = "0x14A3B74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72688", Offset = "0x72688")]
			private set
			{
			}
		}

		[Token(Token = "0x17000A55")]
		public AudioSource gamepadSpeakerSource
		{
			[Token(Token = "0x6005B8C")]
			[Address(RVA = "0x14A3B7C", Offset = "0x14A3B7C", VA = "0x14A3B7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72698", Offset = "0x72698")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B8D")]
			[Address(RVA = "0x14A3B84", Offset = "0x14A3B84", VA = "0x14A3B84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x726A8", Offset = "0x726A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x14A3B8C", Offset = "0x14A3B8C", VA = "0x14A3B8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0x14A3BE8", Offset = "0x14A3BE8", VA = "0x14A3BE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x14A3400", Offset = "0x14A3400", VA = "0x14A3400")]
		public void Ball_OnAimStart()
		{
		}

		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x14A3A68", Offset = "0x14A3A68", VA = "0x14A3A68")]
		public void Stop()
		{
		}

		[Token(Token = "0x6005B92")]
		[Address(RVA = "0x14A3554", Offset = "0x14A3554", VA = "0x14A3554")]
		public void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
		{
		}

		[Token(Token = "0x6005B93")]
		[Address(RVA = "0x14A3ABC", Offset = "0x14A3ABC", VA = "0x14A3ABC")]
		public void StopAim()
		{
		}

		[Token(Token = "0x6005B94")]
		[Address(RVA = "0x14A3710", Offset = "0x14A3710", VA = "0x14A3710")]
		public void Ball_OnPreShoot(Vector3 obj)
		{
		}

		[Token(Token = "0x6005B95")]
		[Address(RVA = "0x14A3C04", Offset = "0x14A3C04", VA = "0x14A3C04")]
		public GolfPullSimple()
		{
		}
	}
}
