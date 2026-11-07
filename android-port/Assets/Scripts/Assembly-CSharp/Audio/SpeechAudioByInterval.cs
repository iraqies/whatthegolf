using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013B2")]
	public abstract class SpeechAudioByInterval : SpeechAudioBase
	{
		[Token(Token = "0x4006A03")]
		[FieldOffset(Offset = "0x20")]
		public AudioAttribute interval;

		[Token(Token = "0x4006A04")]
		[FieldOffset(Offset = "0x30")]
		protected float m_nextSoundTime;

		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x16CEAD0", Offset = "0x16CEAD0", VA = "0x16CEAD0", Slot = "6")]
		protected override void PlayClip()
		{
		}

		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x16CEB14", Offset = "0x16CEB14", VA = "0x16CEB14")]
		protected SpeechAudioByInterval()
		{
		}
	}
}
