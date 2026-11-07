using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x2001383")]
	public class AudioPitchModifier : BaseAudioModifier
	{
		[Token(Token = "0x40068BC")]
		[FieldOffset(Offset = "0x44")]
		private float pitch;

		[Token(Token = "0x40068BD")]
		[FieldOffset(Offset = "0x48")]
		private AudioPitchToTimeScale timescalePitcher;

		[Token(Token = "0x6005B22")]
		[Address(RVA = "0x150B08C", Offset = "0x150B08C", VA = "0x150B08C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B23")]
		[Address(RVA = "0x150B330", Offset = "0x150B330", VA = "0x150B330", Slot = "4")]
		protected override void OnValueChange(float _value)
		{
		}

		[Token(Token = "0x6005B24")]
		[Address(RVA = "0x150B380", Offset = "0x150B380", VA = "0x150B380")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B25")]
		[Address(RVA = "0x150B4C8", Offset = "0x150B4C8", VA = "0x150B4C8")]
		public AudioPitchModifier()
		{
		}
	}
}
