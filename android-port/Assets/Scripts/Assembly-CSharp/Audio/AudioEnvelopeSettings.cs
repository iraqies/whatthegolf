using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013AB")]
	public class AudioEnvelopeSettings : MonoBehaviour
	{
		[Token(Token = "0x40069E7")]
		[FieldOffset(Offset = "0x18")]
		public ADSREnvelope envelope;

		[Token(Token = "0x40069E8")]
		[FieldOffset(Offset = "0x20")]
		public bool useOnThisObject;

		[Token(Token = "0x40069E9")]
		[FieldOffset(Offset = "0x21")]
		public bool selfTriggerEnvelope;

		[Token(Token = "0x40069EA")]
		[FieldOffset(Offset = "0x28")]
		private AudioSource audioSource;

		[Token(Token = "0x40069EB")]
		[FieldOffset(Offset = "0x30")]
		private uint samplesUntillTrigger;

		[Token(Token = "0x40069EC")]
		[FieldOffset(Offset = "0x34")]
		private bool sourceIsPlaying;

		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x142CE40", Offset = "0x142CE40", VA = "0x142CE40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x142CE9C", Offset = "0x142CE9C", VA = "0x142CE9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x142CF24", Offset = "0x142CF24", VA = "0x142CF24")]
		public void Trigger(double startTime, bool resetVolume = false)
		{
		}

		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x142CFB8", Offset = "0x142CFB8", VA = "0x142CFB8")]
		private void OnAudioFilterRead(float[] buffer, int numChannels)
		{
		}

		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x142D0C4", Offset = "0x142D0C4", VA = "0x142D0C4")]
		public AudioEnvelopeSettings()
		{
		}
	}
}
