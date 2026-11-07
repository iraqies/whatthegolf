using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013DA")]
	public class AudioValueTimescale : BaseAudioValue
	{
		[Token(Token = "0x17000A7B")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C9C")]
			[Address(RVA = "0x1512500", Offset = "0x1512500", VA = "0x1512500", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x1512508", Offset = "0x1512508", VA = "0x1512508")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x1512514", Offset = "0x1512514", VA = "0x1512514", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x1512548", Offset = "0x1512548", VA = "0x1512548", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x151258C", Offset = "0x151258C", VA = "0x151258C")]
		public AudioValueTimescale()
		{
		}
	}
}
