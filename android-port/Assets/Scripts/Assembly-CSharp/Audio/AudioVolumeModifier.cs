using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x2001385")]
	public class AudioVolumeModifier : BaseAudioModifier
	{
		[Token(Token = "0x40068C3")]
		[FieldOffset(Offset = "0x44")]
		public bool zeroVolumeBelowMinValue;

		[Token(Token = "0x40068C4")]
		[FieldOffset(Offset = "0x45")]
		public bool startOnFirstValueChange;

		[Token(Token = "0x40068C5")]
		[FieldOffset(Offset = "0x46")]
		public bool handlePlayback;

		[Token(Token = "0x40068C6")]
		[FieldOffset(Offset = "0x47")]
		public bool handleByValue;

		[Token(Token = "0x40068C7")]
		[FieldOffset(Offset = "0x48")]
		public bool handleByVolume;

		[Token(Token = "0x40068C8")]
		[FieldOffset(Offset = "0x50")]
		private AudioFromSurfaceModifier surfaceModifier;

		[Token(Token = "0x40068C9")]
		[FieldOffset(Offset = "0x58")]
		private float volume;

		[Token(Token = "0x40068CA")]
		[FieldOffset(Offset = "0x5C")]
		private bool valueChanged;

		[Token(Token = "0x6005B2A")]
		[Address(RVA = "0x1513018", Offset = "0x1513018", VA = "0x1513018")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B2B")]
		[Address(RVA = "0x1513078", Offset = "0x1513078", VA = "0x1513078", Slot = "4")]
		protected override void OnValueChange(float _value)
		{
		}

		[Token(Token = "0x6005B2C")]
		[Address(RVA = "0x1513170", Offset = "0x1513170", VA = "0x1513170")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B2D")]
		[Address(RVA = "0x1513450", Offset = "0x1513450", VA = "0x1513450")]
		public AudioVolumeModifier()
		{
		}
	}
}
