using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x200005E")]
	public struct ControllerElementTarget
	{
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x0")]
		private Controller.Element DxtFUupqUGmyUsjBAudqHmDVBidJ;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x8")]
		private AxisRange dnqcDaKuDzTeZpkjWrulGAfmNtHmA;

		[Token(Token = "0x170000FF")]
		public int elementIdentifierId
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x235CFB8", Offset = "0x235CFB8", VA = "0x235CFB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000100")]
		public AxisRange axisRange
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x235CFD0", Offset = "0x235CFD0", VA = "0x235CFD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x235CFD8", Offset = "0x235CFD8", VA = "0x235CFD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public Controller controller
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x235CFE0", Offset = "0x235CFE0", VA = "0x235CFE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x235CD10", Offset = "0x235CD10", VA = "0x235CD10")]
		public ControllerElementTarget(ActionElementMap P_0)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x235CE3C", Offset = "0x235CE3C", VA = "0x235CE3C")]
		public ControllerElementTarget(IControllerElementTarget P_0)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x235CFF8", Offset = "0x235CFF8", VA = "0x235CFF8")]
		public static implicit operator ControllerElementTarget(ActionElementMap actionElementMap)
		{
			return default;
		}
	}
}
