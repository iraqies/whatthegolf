using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013CF")]
	public class AudioValueLFO : BaseAudioValue
	{
		[Token(Token = "0x20013D0")]
		public enum Signal
		{
			[Token(Token = "0x4006A7F")]
			Sine = 0,
			[Token(Token = "0x4006A80")]
			Square = 1
		}

		[Token(Token = "0x4006A76")]
		[FieldOffset(Offset = "0x38")]
		public bool useAffector;

		[Token(Token = "0x4006A77")]
		[FieldOffset(Offset = "0x40")]
		public AudioValueMapper Affector;

		[Token(Token = "0x4006A78")]
		[FieldOffset(Offset = "0x48")]
		public bool isOn;

		[Token(Token = "0x4006A79")]
		[FieldOffset(Offset = "0x4C")]
		public float rate;

		[Token(Token = "0x4006A7A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x5AACC", Offset = "0x5AACC")]
		public float depth;

		[Token(Token = "0x4006A7B")]
		[FieldOffset(Offset = "0x54")]
		public Signal signal;

		[Token(Token = "0x4006A7C")]
		[FieldOffset(Offset = "0x58")]
		private float m_rate;

		[Token(Token = "0x4006A7D")]
		[FieldOffset(Offset = "0x5C")]
		private float m_depth;

		[Token(Token = "0x17000A72")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C66")]
			[Address(RVA = "0x1510064", Offset = "0x1510064", VA = "0x1510064", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x151006C", Offset = "0x151006C", VA = "0x151006C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x1510088", Offset = "0x1510088", VA = "0x1510088", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x15100CC", Offset = "0x15100CC", VA = "0x15100CC", Slot = "5")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x1510210", Offset = "0x1510210", VA = "0x1510210", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x1510294", Offset = "0x1510294", VA = "0x1510294")]
		public AudioValueLFO()
		{
		}
	}
}
