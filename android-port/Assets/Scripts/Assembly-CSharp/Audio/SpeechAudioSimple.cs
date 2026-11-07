using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013B1")]
	public class SpeechAudioSimple : SpeechAudioByInterval
	{
		[Token(Token = "0x4006A02")]
		[FieldOffset(Offset = "0x38")]
		public ClipSettingsCollection clips;

		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0x16CEB1C", Offset = "0x16CEB1C", VA = "0x16CEB1C", Slot = "5")]
		public override void UpdateSpeech()
		{
		}

		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x16CEB64", Offset = "0x16CEB64", VA = "0x16CEB64", Slot = "6")]
		protected override void PlayClip()
		{
		}

		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x16CEC80", Offset = "0x16CEC80", VA = "0x16CEC80")]
		public SpeechAudioSimple()
		{
		}
	}
}
