using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x2001384")]
	[Attribute(Name = "RequireComponent", RVA = "0x48E44", Offset = "0x48E44")]
	public class AudioTremoloModifier : BaseAudioModifier
	{
		[Token(Token = "0x40068BE")]
		[FieldOffset(Offset = "0x44")]
		public float minFrequency;

		[Token(Token = "0x40068BF")]
		[FieldOffset(Offset = "0x48")]
		public float maxFrequency;

		[Token(Token = "0x40068C0")]
		[FieldOffset(Offset = "0x4C")]
		private float depth;

		[Token(Token = "0x40068C1")]
		[FieldOffset(Offset = "0x50")]
		private float frequency;

		[Token(Token = "0x40068C2")]
		[FieldOffset(Offset = "0x58")]
		private AudioTremolo tremolo;

		[Token(Token = "0x6005B26")]
		[Address(RVA = "0x150E260", Offset = "0x150E260", VA = "0x150E260")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B27")]
		[Address(RVA = "0x150E2CC", Offset = "0x150E2CC", VA = "0x150E2CC", Slot = "4")]
		protected override void OnValueChange(float _value)
		{
		}

		[Token(Token = "0x6005B28")]
		[Address(RVA = "0x150E33C", Offset = "0x150E33C", VA = "0x150E33C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B29")]
		[Address(RVA = "0x150E3D4", Offset = "0x150E3D4", VA = "0x150E3D4")]
		public AudioTremoloModifier()
		{
		}
	}
}
