using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200136C")]
	public class AudioEventAsset : ScriptableObject
	{
		[Token(Token = "0x400681B")]
		[FieldOffset(Offset = "0x18")]
		public bool debug;

		[Token(Token = "0x400681C")]
		[FieldOffset(Offset = "0x1C")]
		public AudioUtility.AudioManagerVoice voice;

		[Token(Token = "0x400681D")]
		[FieldOffset(Offset = "0x20")]
		public float cooldown;

		[Token(Token = "0x400681E")]
		[FieldOffset(Offset = "0x28")]
		public ClipSettingsCollection clips;

		[Token(Token = "0x400681F")]
		[FieldOffset(Offset = "0x30")]
		private float nextSoundTime;

		[Token(Token = "0x4006820")]
		[FieldOffset(Offset = "0x38")]
		private AudioSources m_useVoice;

		[Token(Token = "0x17000A42")]
		public float NextSoundTime
		{
			[Token(Token = "0x6005ABB")]
			[Address(RVA = "0x142D13C", Offset = "0x142D13C", VA = "0x142D13C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005ABC")]
			[Address(RVA = "0x142D144", Offset = "0x142D144", VA = "0x142D144")]
			set
			{
			}
		}

		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x142D14C", Offset = "0x142D14C", VA = "0x142D14C")]
		public void ResetOnSceneLoad()
		{
		}

		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x1420408", Offset = "0x1420408", VA = "0x1420408")]
		public void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
		}

		[Token(Token = "0x6005ABF")]
		[Address(RVA = "0x142D158", Offset = "0x142D158", VA = "0x142D158")]
		public void Play(Vector3 position, PlayClipOnAudioEvent.Overrides _override, float volumeMultiplier = 1f, float pitchMultiplier = 1f, bool disableSpatial = false)
		{
		}

		[Token(Token = "0x6005AC0")]
		[Address(RVA = "0x142D15C", Offset = "0x142D15C", VA = "0x142D15C")]
		public void PlayDelayed(Vector3 position, float delay, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}

		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x142D2A8", Offset = "0x142D2A8", VA = "0x142D2A8")]
		public AudioEventAsset()
		{
		}
	}
}
