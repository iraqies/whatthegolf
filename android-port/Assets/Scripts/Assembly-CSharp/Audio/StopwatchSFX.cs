using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013B3")]
	[Attribute(Name = "RequireComponent", RVA = "0x48F54", Offset = "0x48F54")]
	public class StopwatchSFX : MonoBehaviour
	{
		[Token(Token = "0x4006A05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClipSettings countdownSFX;

		[Token(Token = "0x4006A06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClipSettings raceStartSFX;

		[Token(Token = "0x4006A07")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClipSettingsCollection tickSFX;

		[Token(Token = "0x4006A08")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioSource audioSourcePrefab;

		[Token(Token = "0x4006A09")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int setDoubleTempoAtTime;

		[Token(Token = "0x4006A0A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool playSoundOnStopwatchEnd;

		[Token(Token = "0x4006A0B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClipSettings endSFX;

		[Token(Token = "0x4006A0C")]
		[FieldOffset(Offset = "0x48")]
		private PlayClipInfo m_next;

		[Token(Token = "0x4006A0D")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource[] m_audioSources;

		[Token(Token = "0x4006A0E")]
		[FieldOffset(Offset = "0x68")]
		private Metronome metronome;

		[Token(Token = "0x4006A0F")]
		[FieldOffset(Offset = "0x70")]
		private int index;

		[Token(Token = "0x4006A10")]
		[FieldOffset(Offset = "0x74")]
		private float timer;

		[Token(Token = "0x4006A11")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isDoubleTime;

		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x16E28C8", Offset = "0x16E28C8", VA = "0x16E28C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x16E2B90", Offset = "0x16E2B90", VA = "0x16E2B90")]
		public void PlayCountdown()
		{
		}

		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x16E2C2C", Offset = "0x16E2C2C", VA = "0x16E2C2C")]
		public void PlayStartSFX()
		{
		}

		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x16E2CC8", Offset = "0x16E2CC8", VA = "0x16E2CC8")]
		private void Metronome_Ticked(double obj)
		{
		}

		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x16E2D94", Offset = "0x16E2D94", VA = "0x16E2D94")]
		public void StartStopwatch(float time)
		{
		}

		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x16E2DB4", Offset = "0x16E2DB4", VA = "0x16E2DB4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x16E2DD0", Offset = "0x16E2DD0", VA = "0x16E2DD0")]
		private void Update()
		{
		}

		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x16E2ED0", Offset = "0x16E2ED0", VA = "0x16E2ED0")]
		public StopwatchSFX()
		{
		}
	}
}
